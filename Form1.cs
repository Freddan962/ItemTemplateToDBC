using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace ItemTemplateToDBC
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        string conString;

        private Dictionary<int, Item> items = new Dictionary<int, Item>();
        private DBCReader reader = new DBCReader("ItemData.dbc");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hostField.Text = "127.0.0.1";
            usernameField.Text = "root";
            passwordField.Text = "ascent";
            portField.Text = "3306";
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            loadItems();
            itemsToDBC();
        }

        private void loadItems()
        {
            conString = $"SERVER={hostField.Text};PORT={portField.Text};DATABASE=world;UID={usernameField.Text};PASSWORD={passwordField.Text};";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = conString;
                conn.Open();

                string query = "SELECT entry AS itemID, class AS itemClass, subclass AS itemSubClass, SoundOverrideSubclass AS sound_override_subclassid, Material AS materialID, displayid AS itemDisplayInfo, InventoryType AS inventorySlotID, sheath AS sheathID FROM item_template";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Item item = new Item();

                    item.itemID = int.Parse(reader["itemID"].ToString());
                    item.itemClass = int.Parse(reader["itemClass"].ToString());
                    item.itemSubClass = int.Parse(reader["itemSubclass"].ToString());
                    item.sound_override_subclassid = int.Parse(reader["sound_override_subclassid"].ToString());
                    item.materialID = int.Parse(reader["materialID"].ToString());
                    item.itemDisplayInfo = int.Parse(reader["itemDisplayInfo"].ToString());
                    item.inventorySlotID = int.Parse(reader["inventorySlotID"].ToString());
                    item.sheathID = int.Parse(reader["sheathID"].ToString());

                    items.Add(item.itemID, item);
                }

                string time = DateTime.Now.ToString("HH:mm:ss");
                status.Text = time + ": Loaded Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemsToDBC()
        {
            BinaryWriter writer = new BinaryWriter(File.Open("Item.dbc", FileMode.Create));

            DBCHeader header = new DBCHeader();
            header.DBCmagic = DBCReader.DBCFmtSig;
            header.RecordsCount = (uint)items.Count;
            header.FieldsCount = (uint)reader.FieldsCount;
            header.RecordSize = (uint)reader.RecordSize;
            header.StringTableSize = (uint)reader.StringTableSize;
            //Console.WriteLine($"{header.RecordsCount} : {(uint)items.Count}");

            //Write header content
            writer.Write(DBCReader.DBCFmtSig);
            writer.Write(header.RecordsCount);
            Console.WriteLine($"recordsCount : {header.RecordsCount}");
            writer.Write(header.FieldsCount);
            Console.WriteLine($"fieldsCount : {header.FieldsCount}");
            writer.Write(header.RecordSize);
            writer.Write(header.StringTableSize);

            //Write item struct
            foreach (var pair in items)
            {
                Item item = pair.Value;

                byte[] buffer = new byte[Marshal.SizeOf(typeof(Item))];
                GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                Marshal.StructureToPtr(item, handle.AddrOfPinnedObject(), true);
                writer.Write(buffer, 0, buffer.Length);
                handle.Free();
            }

            //Write string table
            foreach (var pair in reader.StringTable)
                writer.Write(Encoding.UTF8.GetBytes(pair.Value + "\0"));

            writer.Close();

            string time = DateTime.Now.ToString("HH:mm:ss");
            status.Text = time + ": Conversion to DBC complete";
        }
    }
}
