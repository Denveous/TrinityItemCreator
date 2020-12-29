using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TrinityItemCreator.MyClass
{
    class Functions
    {
        private Form_Main mainForm;
        public static bool preLoadTemplate;
        public static bool preLoadSubClassMenu;
        public static string templateName;
        public Functions() { }

        public Functions(Form_Main form1)
        {
            mainForm = form1;
        }

        private Dictionary<int, Item> items = new Dictionary<int, Item>();

        /// <summary>
        /// Get string value between [first] a and [last] b.
        /// </summary>
        private string Between(string text, string a, string b)
        {
            int posA = text.IndexOf(a);
            int posB = text.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return text.Substring(adjustedPosA, posB - adjustedPosA);
        }

        public void SetFlagsMasksButtonCurrentValue()
        {
            mainForm.ButtonAllowableClass.Text = mainForm.ButtonAllowableClass.Text.Replace
            (
                Between(mainForm.ButtonAllowableClass.Text, "(", ")"), MyData.Field_AllowableClass.ToString()
            );

            mainForm.ButtonAllowableRace.Text = mainForm.ButtonAllowableRace.Text.Replace
            (
                Between(mainForm.ButtonAllowableRace.Text, "(", ")"), MyData.Field_AllowableRace.ToString()
            );

            mainForm.ButtonBagFamilyMask.Text = mainForm.ButtonBagFamilyMask.Text.Replace
            (
                Between(mainForm.ButtonBagFamilyMask.Text, "(", ")"), MyData.Field_BagFamily.ToString()
            );

            mainForm.ButtonFlag.Text = mainForm.ButtonFlag.Text.Replace
            (
                Between(mainForm.ButtonFlag.Text, "(", ")"), MyData.Field_Flags.ToString()
            );

            mainForm.ButtonFlagExtra.Text = mainForm.ButtonFlagExtra.Text.Replace
            (
                Between(mainForm.ButtonFlagExtra.Text, "(", ")"), MyData.Field_FlagsExtra.ToString()
            );

            mainForm.ButtonFlagCustom.Text = mainForm.ButtonFlagCustom.Text.Replace
            (
                Between(mainForm.ButtonFlagCustom.Text, "(", ")"), MyData.Field_flagsCustom.ToString()
            );
        }

        public static bool IsDBConnected()
        {
            string conn_info = $"SERVER={Properties.Settings.Default.db_hostname};PORT={Properties.Settings.Default.db_port}" +
                $";DATABASE={Properties.Settings.Default.db_name};UID={Properties.Settings.Default.db_user}" +
                $";PASSWORD={Properties.Settings.Default.db_pass};SSLMODE=NONE;";

            MySqlConnection conn = new MySqlConnection(conn_info);
            try { conn.Open(); }
            catch { return false; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }

            return true;
        }

        public async void DelayMainFormPainting()
        {
            mainForm.Opacity = 0;
            await Task.Delay(200);
            mainForm.Opacity = .99;
        }

        public bool LoadItems()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            string conString = $"SERVER={Properties.Settings.Default.db_hostname};PORT={Properties.Settings.Default.db_port}" +
                $";DATABASE={Properties.Settings.Default.db_name};UID={Properties.Settings.Default.db_user}" +
                $";PASSWORD={Properties.Settings.Default.db_pass};SSLMODE=NONE;";

            try
            {
                Item item = new Item();
                conn.ConnectionString = conString;
                conn.Open();

                string query = "SELECT entry AS itemID, class AS itemClass, subclass AS itemSubClass, SoundOverrideSubclass AS sound_override_subclassid, " +
                    "Material AS materialID, displayid AS itemDisplayInfo, InventoryType AS inventorySlotID, sheath AS sheathID FROM item_template " +
                    "ORDER BY entry ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                using (StreamReader sr = new StreamReader("data/itemdata.csv"))
                {
                    string currentLine;
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(currentLine))
                        {
                            var values = currentLine.Split(',');

                            item.itemID = int.Parse(values[0]);
                            item.itemClass = int.Parse(values[1]);
                            item.itemSubClass = int.Parse(values[2]);
                            item.sound_override_subclassid = int.Parse(values[3]);
                            item.materialID = int.Parse(values[4]);
                            item.itemDisplayInfo = int.Parse(values[5]);
                            item.inventorySlotID = int.Parse(values[6]);
                            item.sheathID = int.Parse(values[7]);

                            items.Add(item.itemID, item);
                        }
                    }
                }

                while (reader.Read())
                {
                    item.itemID = int.Parse(reader["itemID"].ToString());

                    // check if item from dbc is same as item from item_template
                    if (items.ContainsKey(item.itemID))
                        items.Remove(item.itemID); // remove because we add the values from db which stays up to date!

                    item.itemClass = int.Parse(reader["itemClass"].ToString());
                    item.itemSubClass = int.Parse(reader["itemSubclass"].ToString());
                    item.sound_override_subclassid = int.Parse(reader["sound_override_subclassid"].ToString());
                    item.materialID = int.Parse(reader["materialID"].ToString());
                    item.itemDisplayInfo = int.Parse(reader["itemDisplayInfo"].ToString());
                    item.inventorySlotID = int.Parse(reader["inventorySlotID"].ToString());
                    item.sheathID = int.Parse(reader["sheathID"].ToString());

                    items.Add(item.itemID, item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public void ItemsToDBC()
        {
            DBCReader reader = new DBCReader("data/itemheader.dbc");
            BinaryWriter writer = new BinaryWriter(File.OpenWrite("Item.dbc"));

            DBCHeader header = new DBCHeader
            {
                DBCmagic = DBCReader.DBCFmtSig,
                RecordsCount = (uint)items.Count,
                FieldsCount = (uint)reader.FieldsCount,
                RecordSize = (uint)reader.RecordSize,
                StringTableSize = (uint)reader.StringTableSize
            };

            //Write header content
            writer.Write(DBCReader.DBCFmtSig);
            writer.Write(header.RecordsCount);
            writer.Write(header.FieldsCount);
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
            MessageBox.Show("Conversion to DBC complete, please check main folder new Item.dbc file!");
        }

        public void ImportSQLItem()
        {
            bool ItWorked = true;
            bool duplicateItem = false;
            string conString = $"SERVER={Properties.Settings.Default.db_hostname};PORT={Properties.Settings.Default.db_port}" +
                $";DATABASE={Properties.Settings.Default.db_name};UID={Properties.Settings.Default.db_user}" +
                $";PASSWORD={Properties.Settings.Default.db_pass};SSLMODE=NONE;";

            MySqlConnection conn = new MySqlConnection(conString);
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = QueryHandler.GetExportQuery();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle Duplicate Items 
                if (ex.Message.StartsWith("Duplicate"))
                {
                    duplicateItem = true;
                    string dupeitemID = System.Text.RegularExpressions.Regex.Match(ex.Message, @"\d+").Value;
                    DialogResult result = MessageBox.Show($"Duplicate item '" + dupeitemID + "' - would you like to replace this item in your database?", "Item Exists", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string deletequery = "DELETE FROM item_template where entry=" + dupeitemID;
                        MySqlCommand deletecmd = new MySqlCommand(deletequery, conn);
                        deletecmd.ExecuteNonQuery();
                        try
                        {
                            MySqlCommand comm = conn.CreateCommand();
                            comm.CommandText = QueryHandler.GetExportQuery();
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex2)
                        {
                            ItWorked = false;
                            MessageBox.Show(ex2.Message);
                        }
                        finally
                        {
                            if (ItWorked)
                                MessageBox.Show($"Replaced item:\n\n" +
                                    $"{MyData.Field_entry} - {MyData.Field_name}");

                            conn.Close();
                        }
                        
                    }
                }// 
                  else
                {
                    ItWorked = false;
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                if (ItWorked && !duplicateItem)
                    MessageBox.Show($"Successfully imported item:\n\n" +
                        $"{MyData.Field_entry} - {MyData.Field_name}");

                conn.Close();
            }
        }

        public void DoResetAllFields()
        {
            // main form changes will update MyData Fields automatically from main form
            foreach (var mtextBox in mainForm.Controls.OfType<MyTextBox>())
            {
                if (mtextBox.Name == "tb_stackable") mtextBox.Text = "1";
                else if (mtextBox.Name == "tb_item_name") mtextBox.Text = "";
                else if (mtextBox.Name == "tb_item_description") mtextBox.Text = "";
                else if (mtextBox.Name == "tb_buy_count") mtextBox.Text = "1";
                else mtextBox.Text = "0";
            }

            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>())
            {
                if (comboBox.Name == "cb_item_material") comboBox.SelectedIndex = 1;
                else comboBox.SelectedIndex = 0;
            }

            // MyData Fields not in main form
            MyData.Field_entry = 0;
            MyData.Field_AllowableClass = -1;
            MyData.Field_AllowableRace = -1;
            MyData.Field_BagFamily = 0;
            MyData.Field_Flags = 0;
            MyData.Field_FlagsExtra = 0;
            MyData.Field_flagsCustom = 0;
            MyData.Field_arcane_res = 0;
            MyData.Field_fire_res = 0;
            MyData.Field_frost_res = 0;
            MyData.Field_holy_res = 0;
            MyData.Field_nature_res = 0;
            MyData.Field_shadow_res = 0;
            MyData.Field_minMoneyLoot = 0;
            MyData.Field_maxMoneyLoot = 0;
            MyData.Field_lockid = 0;
            MyData.Field_LanguageID = 0;
            MyData.Field_PageMaterial = 0;
            MyData.Field_PageText = 0;
            MyData.Field_RequiredReputationFaction = 0;
            MyData.Field_RequiredReputationRank = 0;
            MyData.Field_RequiredDisenchantSkill = -1;
            MyData.Field_DisenchantID = 0;
            MyData.Field_requiredhonorrank = 0;
            MyData.Field_RequiredCityRank = 0;
            MyData.Field_RequiredSkill = 0;
            MyData.Field_RequiredSkillRank = 0;
            MyData.Field_requiredspell = 0;
            MyData.Field_Map = 0;
            MyData.Field_area = 0;
            MyData.Field_duration = 0;
            MyData.Field_startquest = 0;
            MyData.Field_GemProperties = 0;
            MyData.Field_HolidayId = 0;
            MyData.Field_SoundOverrideSubclass = -1;
            MyData.Field_ItemLimitCategory = 0;
            MyData.Field_ScriptName = "";
        }

        public int GenerateOddEvenNumber(Random random, int rangeMin, int rangeMax, int numberType = 0)
        {
            int randomNumber = 0;

            switch (numberType)
            {
                case 0: // odd and even
                    randomNumber  = random.Next(rangeMin, rangeMax);
                    break;
                case 1: // odd
                    {
                        int ans = random.Next(rangeMin, rangeMax);
                        if (ans % 2 == 1) return ans;
                        else
                        {
                            if (ans + 1 <= rangeMax)
                                randomNumber = ans + 1;
                            else if (ans - 1 >= rangeMin)
                                randomNumber = ans - 1;
                            else return 0;
                        }
                    }
                    break;
                case 2: // even
                    randomNumber = (2 * random.Next(rangeMin / 2, rangeMax / 2));
                    break;
            }

            return randomNumber;
        }

        public void UnBlurMainForm()
        {
            foreach (var menuStrip in mainForm.Controls.OfType<MenuStrip>()) menuStrip.Enabled = true;
            foreach (var mtextBox in mainForm.Controls.OfType<MyTextBox>()) mtextBox.Enabled = true;
            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>()) comboBox.Enabled = true;
            foreach (var button in mainForm.Controls.OfType<Button>()) button.Enabled = true;
            foreach (var picBox in mainForm.Controls.OfType<PictureBox>()) picBox.Enabled = true;

            mainForm.panel1.BackColor = Color.DarkSlateGray;
        }

        public void LoadMyCustomTemplate(string xmFileName, bool dragged = false)
        {
            string path = "templates";
            Directory.CreateDirectory(path);

            string[] lines = new string[139];

            XmlDocument doc = new XmlDocument();
            if (dragged)
                doc.Load($"{xmFileName}");
            else
                doc.Load($"{path}\\{xmFileName}.xml");

            int count = 0;
            foreach (XmlNode node in doc.SelectNodes("//field"))
            {
                lines[count] = $"{node.InnerText}";
                count++;
            }
            templateName = xmFileName;
            LoadDefaultTemplate(14, lines);
        }

        public void LoadDefaultTemplate(int templateID, string[] lines = null)
        {
            DoResetAllFields();

            switch (templateID)
            {
                case 0: // weapon
                    {
                        MyData.Field_name = "My One Handed Sword";
                        MyData.Field_Quality = 4;
                        MyData.Field_sheath = 3;
                        MyData.Field_class = 2;
                        MyData.Field_subclass = 7;
                        MyData.Field_InventoryType = 13;
                        MyData.Field_Material = 1;
                        MyData.Field_dmg_min1 = 100;
                        MyData.Field_dmg_max1 = 200;
                        MyData.Field_delay = 1000;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 1: // armor
                    {
                        MyData.Field_name = "My Helm Cloth";
                        MyData.Field_Quality = 4;
                        MyData.Field_class = 4;
                        MyData.Field_subclass = 1;
                        MyData.Field_InventoryType = 5;
                        MyData.Field_Material = 7;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 2: // gem
                    {
                        MyData.Field_class = 3;
                        MyData.Field_subclass = 6;
                        MyData.Field_name = "My Meta Gem";
                        MyData.Field_description = "Only fits in a meta gem slot.";
                        MyData.Field_Material = -1;
                        MyData.Field_GemProperties = 942;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 3: // projectile
                    {
                        MyData.Field_class = 6;
                        MyData.Field_subclass = 3;
                        MyData.Field_name = "My Projectile Bullets";
                        MyData.Field_description = "More Pew Pew,Less QQ";
                        MyData.Field_InventoryType = 24;
                        MyData.Field_BuyCount = 200;
                        MyData.Field_stackable = 200;
                        MyData.Field_Material = 2;
                        MyData.Field_dmg_min1 = 100;
                        MyData.Field_dmg_max1 = 200;
                        MyData.Field_delay = 1000;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 4:// container
                    {
                        MyData.Field_class = 1;
                        MyData.Field_name = "My Fancy Container";
                        MyData.Field_description = "Some Extra Slots";
                        MyData.Field_ContainerSlots = 36;
                        MyData.Field_Material = 8;
                        MyData.Field_InventoryType = 18;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 5: // quiver
                    {
                        MyData.Field_class = 11;
                        MyData.Field_subclass = 2;
                        MyData.Field_name = "My Fancy Quiver for Arrows";
                        MyData.Field_description = "Some Extra Space for Arrows";
                        MyData.Field_ContainerSlots = 36;
                        MyData.Field_Material = 8;
                        MyData.Field_InventoryType = 27;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 6: // glyph
                    {
                        MyData.Field_class = 16;
                        MyData.Field_subclass = 11;
                        MyData.Field_name = "My Custom Glyph";
                        MyData.Field_Material = 4;
                        MyData.Field_Flags = 64;
                        MyData.Field_spellid_1 = 65244;
                        MyData.Field_spellcooldown_1 = 0;
                        MyData.Field_BagFamily = 16;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 7: // recipe
                    {
                        MyData.Field_class = 9;
                        MyData.Field_subclass = 2;
                        MyData.Field_name = "My Custom Recipe";
                        MyData.Field_Material = -1;
                        MyData.Field_Flags = 64;
                        MyData.Field_spellid_1 = 483;
                        MyData.Field_spellcharges_1 = -1;
                        MyData.Field_spellppmRate_1 = -1;
                        MyData.Field_spellid_2 = 3336;
                        MyData.Field_spelltrigger_2 = 6;
                        MyData.Field_spellcooldown_2 = -1;
                        MyData.Field_spellcategorycooldown_2 = -1;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 8: // quest
                    {
                        MyData.Field_class = 12;
                        MyData.Field_subclass = 0;
                        MyData.Field_name = "My Custom Quest Item";
                        MyData.Field_Material = -1;
                        MyData.Field_startquest = 337;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 9: // key
                    {
                        MyData.Field_class = 13;
                        MyData.Field_subclass = 0;
                        MyData.Field_name = "My Custom Key Item";
                        MyData.Field_Material = -1;
                        MyData.Field_Flags = 64;
                        MyData.Field_spellid_1 = 42323;
                        MyData.Field_spellcharges_1 = -1;
                        MyData.Field_spellppmRate_1 = -1;
                        MyData.Field_spellcooldown_1 = -1;
                        MyData.Field_spellcategorycooldown_1 = -1;
                        MyData.Field_BagFamily = 256;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 10: // reagent
                    {
                        MyData.Field_class = 5;
                        MyData.Field_subclass = 0;
                        MyData.Field_name = "My Custom Reagent";
                        MyData.Field_Material = 2;
                        MyData.Field_stackable = 10;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 11: // trade goods
                    {
                        MyData.Field_class = 7;
                        MyData.Field_subclass = 14;
                        MyData.Field_name = "My Custom Trade Good";
                        MyData.Field_Material = 4;
                        MyData.Field_stackable = 20;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 12: // consumables
                    {
                        MyData.Field_class = 0;
                        MyData.Field_subclass = 5;
                        MyData.Field_name = "My Custom Item Enchantment";
                        MyData.Field_Material = 4;
                        MyData.Field_stackable = 20;
                        MyData.Field_spellid_1 = 26389;
                        MyData.Field_spellcategory_1 = 59;
                        MyData.Field_spellcategorycooldown_1 = 1000;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 13: // miscellaneous
                    {
                        MyData.Field_class = 4;
                        MyData.Field_subclass = 0;
                        MyData.Field_name = "Misc Custom Miscellaneous Item";
                        MyData.Field_Material = 0;
                        MyData.Field_InventoryType = 0;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 14: // custom
                    {
                        MyData.Field_entry = Convert.ToInt32(lines[0]);
                        MyData.Field_class = Convert.ToInt32(lines[1]);
                        MyData.Field_subclass = Convert.ToInt32(lines[2]);
                        MyData.Field_SoundOverrideSubclass = Convert.ToInt32(lines[3]);
                        MyData.Field_name = lines[4];
                        MyData.Field_displayid = Convert.ToInt32(lines[5]);
                        MyData.Field_Quality = Convert.ToInt32(lines[6]);
                        MyData.Field_Flags = Convert.ToUInt64(lines[7]);
                        MyData.Field_FlagsExtra = Convert.ToInt32(lines[8]);
                        MyData.Field_BuyCount = Convert.ToInt32(lines[9]);
                        MyData.Field_BuyPrice = Convert.ToInt32(lines[10]);
                        MyData.Field_SellPrice = Convert.ToInt32(lines[11]);
                        MyData.Field_InventoryType = Convert.ToInt32(lines[12]);
                        MyData.Field_AllowableClass = Convert.ToInt32(lines[13]);
                        MyData.Field_AllowableRace = Convert.ToInt32(lines[14]);
                        MyData.Field_ItemLevel = Convert.ToInt32(lines[15]);
                        MyData.Field_RequiredLevel = Convert.ToInt32(lines[16]);
                        MyData.Field_RequiredSkill = Convert.ToInt32(lines[17]);
                        MyData.Field_RequiredSkillRank = Convert.ToInt32(lines[18]);
                        MyData.Field_requiredspell = Convert.ToInt32(lines[19]);
                        MyData.Field_requiredhonorrank = Convert.ToInt32(lines[20]);
                        MyData.Field_RequiredCityRank = Convert.ToInt32(lines[21]);
                        MyData.Field_RequiredReputationFaction = Convert.ToInt32(lines[22]);
                        MyData.Field_RequiredReputationRank = Convert.ToInt32(lines[23]);
                        MyData.Field_maxcount = Convert.ToInt32(lines[24]);
                        MyData.Field_stackable = Convert.ToInt32(lines[25]);
                        MyData.Field_ContainerSlots = Convert.ToInt32(lines[26]);
                        MyData.Field_StatsCount = Convert.ToInt32(lines[27]);
                        MyData.Field_stat_type1 = Convert.ToInt32(lines[28]);
                        MyData.Field_stat_value1 = Convert.ToInt32(lines[29]);
                        MyData.Field_stat_type2 = Convert.ToInt32(lines[30]);
                        MyData.Field_stat_value2 = Convert.ToInt32(lines[31]);
                        MyData.Field_stat_type3 = Convert.ToInt32(lines[32]);
                        MyData.Field_stat_value3 = Convert.ToInt32(lines[33]);
                        MyData.Field_stat_type4 = Convert.ToInt32(lines[34]);
                        MyData.Field_stat_value4 = Convert.ToInt32(lines[35]);
                        MyData.Field_stat_type5 = Convert.ToInt32(lines[36]);
                        MyData.Field_stat_value5 = Convert.ToInt32(lines[37]);
                        MyData.Field_stat_type6 = Convert.ToInt32(lines[38]);
                        MyData.Field_stat_value6 = Convert.ToInt32(lines[39]);
                        MyData.Field_stat_type7 = Convert.ToInt32(lines[40]);
                        MyData.Field_stat_value7 = Convert.ToInt32(lines[41]);
                        MyData.Field_stat_type8 = Convert.ToInt32(lines[42]);
                        MyData.Field_stat_value8 = Convert.ToInt32(lines[43]);
                        MyData.Field_stat_type9 = Convert.ToInt32(lines[44]);
                        MyData.Field_stat_value9 = Convert.ToInt32(lines[45]);
                        MyData.Field_stat_type10 = Convert.ToInt32(lines[46]);
                        MyData.Field_stat_value10 = Convert.ToInt32(lines[47]);
                        MyData.Field_ScalingStatDistribution = Convert.ToInt32(lines[48]);
                        MyData.Field_ScalingStatValue = Convert.ToInt32(lines[49]);
                        MyData.Field_dmg_min1 = Convert.ToInt32(lines[50]);
                        MyData.Field_dmg_max1 = Convert.ToInt32(lines[51]);
                        MyData.Field_dmg_type1 = Convert.ToInt32(lines[52]);
                        MyData.Field_dmg_min2 = Convert.ToInt32(lines[53]);
                        MyData.Field_dmg_max2 = Convert.ToInt32(lines[54]);
                        MyData.Field_dmg_type2 = Convert.ToInt32(lines[55]);
                        MyData.Field_armor = Convert.ToInt32(lines[56]);
                        MyData.Field_holy_res = Convert.ToInt32(lines[57]);
                        MyData.Field_fire_res = Convert.ToInt32(lines[58]);
                        MyData.Field_nature_res = Convert.ToInt32(lines[59]);
                        MyData.Field_frost_res = Convert.ToInt32(lines[60]);
                        MyData.Field_shadow_res = Convert.ToInt32(lines[61]);
                        MyData.Field_arcane_res = Convert.ToInt32(lines[62]);
                        MyData.Field_delay = Convert.ToInt32(lines[63]);
                        MyData.Field_ammo_type = Convert.ToInt32(lines[64]);
                        MyData.Field_RangedModRange = Convert.ToInt32(lines[65]);
                        MyData.Field_spellid_1 = Convert.ToInt32(lines[66]);
                        MyData.Field_spelltrigger_1 = Convert.ToInt32(lines[67]);
                        MyData.Field_spellcharges_1 = Convert.ToInt32(lines[68]);
                        MyData.Field_spellppmRate_1 = Convert.ToInt32(lines[69]);
                        MyData.Field_spellcooldown_1 = Convert.ToInt32(lines[70]);
                        MyData.Field_spellcategory_1 = Convert.ToInt32(lines[71]);
                        MyData.Field_spellcategorycooldown_1 = Convert.ToInt32(lines[72]);
                        MyData.Field_spellid_2 = Convert.ToInt32(lines[73]);
                        MyData.Field_spelltrigger_2 = Convert.ToInt32(lines[74]);
                        MyData.Field_spellcharges_2 = Convert.ToInt32(lines[75]);
                        MyData.Field_spellppmRate_2 = Convert.ToInt32(lines[76]);
                        MyData.Field_spellcooldown_2 = Convert.ToInt32(lines[77]);
                        MyData.Field_spellcategory_2 = Convert.ToInt32(lines[78]);
                        MyData.Field_spellcategorycooldown_2 = Convert.ToInt32(lines[79]);
                        MyData.Field_spellid_3 = Convert.ToInt32(lines[80]);
                        MyData.Field_spelltrigger_3 = Convert.ToInt32(lines[81]);
                        MyData.Field_spellcharges_3 = Convert.ToInt32(lines[82]);
                        MyData.Field_spellppmRate_3 = Convert.ToInt32(lines[83]);
                        MyData.Field_spellcooldown_3 = Convert.ToInt32(lines[84]);
                        MyData.Field_spellcategory_3 = Convert.ToInt32(lines[85]);
                        MyData.Field_spellcategorycooldown_3 = Convert.ToInt32(lines[86]);
                        MyData.Field_spellid_4 = Convert.ToInt32(lines[87]);
                        MyData.Field_spelltrigger_4 = Convert.ToInt32(lines[88]);
                        MyData.Field_spellcharges_4 = Convert.ToInt32(lines[89]);
                        MyData.Field_spellppmRate_4 = Convert.ToInt32(lines[90]);
                        MyData.Field_spellcooldown_4 = Convert.ToInt32(lines[91]);
                        MyData.Field_spellcategory_4 = Convert.ToInt32(lines[92]);
                        MyData.Field_spellcategorycooldown_4 = Convert.ToInt32(lines[93]);
                        MyData.Field_spellid_5 = Convert.ToInt32(lines[94]);
                        MyData.Field_spelltrigger_5 = Convert.ToInt32(lines[95]);
                        MyData.Field_spellcharges_5 = Convert.ToInt32(lines[96]);
                        MyData.Field_spellppmRate_5 = Convert.ToInt32(lines[97]);
                        MyData.Field_spellcooldown_5 = Convert.ToInt32(lines[98]);
                        MyData.Field_spellcategory_5 = Convert.ToInt32(lines[99]);
                        MyData.Field_spellcategorycooldown_5 = Convert.ToInt32(lines[100]);
                        MyData.Field_bonding = Convert.ToInt32(lines[101]);
                        MyData.Field_description = lines[102]; //.Replace("\r\n", "\\n"); ;
                        MyData.Field_PageText = Convert.ToInt32(lines[103]);
                        MyData.Field_LanguageID = Convert.ToInt32(lines[104]);
                        MyData.Field_PageMaterial = Convert.ToInt32(lines[105]);
                        MyData.Field_startquest = Convert.ToInt32(lines[106]);
                        MyData.Field_lockid = Convert.ToInt32(lines[107]);
                        MyData.Field_Material = Convert.ToInt32(lines[108]);
                        MyData.Field_sheath = Convert.ToInt32(lines[109]);
                        MyData.Field_RandomProperty = Convert.ToInt32(lines[110]);
                        MyData.Field_RandomSuffix = Convert.ToInt32(lines[111]);
                        MyData.Field_block = Convert.ToInt32(lines[112]);
                        MyData.Field_itemset = Convert.ToInt32(lines[113]);
                        MyData.Field_MaxDurability = Convert.ToInt32(lines[114]);
                        MyData.Field_area = Convert.ToInt32(lines[115]);
                        MyData.Field_Map = Convert.ToInt32(lines[116]);
                        MyData.Field_BagFamily = Convert.ToInt32(lines[117]);
                        MyData.Field_TotemCategory = Convert.ToInt32(lines[118]);
                        MyData.Field_socketColor_1 = Convert.ToInt32(lines[119]);
                        MyData.Field_socketContent_1 = Convert.ToInt32(lines[120]);
                        MyData.Field_socketColor_2 = Convert.ToInt32(lines[121]);
                        MyData.Field_socketContent_2 = Convert.ToInt32(lines[122]);
                        MyData.Field_socketColor_3 = Convert.ToInt32(lines[123]);
                        MyData.Field_socketContent_3 = Convert.ToInt32(lines[124]);
                        MyData.Field_socketBonus = Convert.ToInt32(lines[125]);
                        MyData.Field_GemProperties = Convert.ToInt32(lines[126]);
                        MyData.Field_RequiredDisenchantSkill = Convert.ToInt32(lines[127]);
                        MyData.Field_ArmorDamageModifier = Convert.ToInt32(lines[128]);
                        MyData.Field_duration = Convert.ToInt32(lines[129]);
                        MyData.Field_ItemLimitCategory = Convert.ToInt32(lines[130]);
                        MyData.Field_HolidayId = Convert.ToInt32(lines[131]);
                        MyData.Field_ScriptName = lines[132];
                        MyData.Field_DisenchantID = Convert.ToInt32(lines[133]);
                        MyData.Field_FoodType = Convert.ToInt32(lines[134]);
                        MyData.Field_minMoneyLoot = Convert.ToInt32(lines[135]);
                        MyData.Field_maxMoneyLoot = Convert.ToInt32(lines[136]);
                        MyData.Field_flagsCustom = Convert.ToInt32(lines[137]);
                        MyData.Field_VerifiedBuild = Convert.ToInt32(lines[138]);

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                default:
                    {
                        preLoadSubClassMenu = false;
                        // any other template id
                        break;
                    }
            }

            // TEXTBOX
            mainForm.TextBoxItemEntry.Text = MyData.Field_entry.ToString();
            mainForm.tb_item_name.Text = MyData.Field_name;
            mainForm.tb_item_description.Text = MyData.Field_description;
            mainForm.tb_script_name.Text = MyData.Field_ScriptName.ToString();
            mainForm.TextBoxDisplayID.Text = MyData.Field_displayid.ToString();
            mainForm.myTextBox5.Text = MyData.Field_ItemLevel.ToString();
            mainForm.myTextBox6.Text = MyData.Field_RequiredLevel.ToString();
            mainForm.myTextBox7.Text = MyData.Field_stat_value1.ToString();
            mainForm.myTextBox8.Text = MyData.Field_stat_value2.ToString();
            mainForm.myTextBox9.Text = MyData.Field_stat_value3.ToString();
            mainForm.myTextBox10.Text = MyData.Field_stat_value4.ToString();
            mainForm.myTextBox11.Text = MyData.Field_stat_value5.ToString();
            mainForm.myTextBox12.Text = MyData.Field_stat_value6.ToString();
            mainForm.myTextBox13.Text = MyData.Field_stat_value7.ToString();
            mainForm.myTextBox14.Text = MyData.Field_stat_value8.ToString();
            mainForm.myTextBox15.Text = MyData.Field_stat_value9.ToString();
            mainForm.myTextBox16.Text = MyData.Field_stat_value10.ToString();
            mainForm.myTextBox17.Text = MyData.Field_dmg_min1.ToString();
            mainForm.myTextBox18.Text = MyData.Field_dmg_max1.ToString();
            mainForm.myTextBox19.Text = MyData.Field_dmg_max2.ToString();
            mainForm.myTextBox20.Text = MyData.Field_dmg_min2.ToString();
            mainForm.myTextBox21.Text = MyData.Field_RangedModRange.ToString();
            mainForm.myTextBox22.Text = MyData.Field_delay.ToString();
            mainForm.myTextBox23.Text = MyData.Field_ScalingStatDistribution.ToString();
            mainForm.myTextBox24.Text = MyData.Field_ScalingStatValue.ToString();
            mainForm.myTextBox25.Text = MyData.Field_BuyPrice.ToString();
            mainForm.myTextBox26.Text = MyData.Field_SellPrice.ToString();
            mainForm.tb_buy_count.Text = MyData.Field_BuyCount.ToString();
            mainForm.myTextBox28.Text = MyData.Field_itemset.ToString();
            mainForm.tb_stackable.Text = MyData.Field_stackable.ToString();
            mainForm.myTextBox30.Text = MyData.Field_maxcount.ToString();
            mainForm.myTextBox31.Text = MyData.Field_spellid_1.ToString();
            mainForm.myTextBox32.Text = MyData.Field_spellcharges_1.ToString();
            mainForm.myTextBox33.Text = MyData.Field_spellppmRate_1.ToString();
            mainForm.myTextBox34.Text = MyData.Field_spellcooldown_1.ToString();
            mainForm.myTextBox35.Text = MyData.Field_spellcategory_1.ToString();
            mainForm.myTextBox36.Text = MyData.Field_spellcategorycooldown_1.ToString();
            mainForm.myTextBox37.Text = MyData.Field_spellcategorycooldown_2.ToString();
            mainForm.myTextBox38.Text = MyData.Field_spellcategory_2.ToString();
            mainForm.myTextBox39.Text = MyData.Field_spellcooldown_2.ToString();
            mainForm.myTextBox40.Text = MyData.Field_spellppmRate_2.ToString();
            mainForm.myTextBox41.Text = MyData.Field_spellcharges_2.ToString();
            mainForm.myTextBox42.Text = MyData.Field_spellid_2.ToString();
            mainForm.myTextBox43.Text = MyData.Field_spellcategorycooldown_3.ToString();
            mainForm.myTextBox44.Text = MyData.Field_spellcategory_3.ToString();
            mainForm.myTextBox45.Text = MyData.Field_spellcooldown_3.ToString();
            mainForm.myTextBox46.Text = MyData.Field_spellppmRate_3.ToString();
            mainForm.myTextBox47.Text = MyData.Field_spellcharges_3.ToString();
            mainForm.myTextBox48.Text = MyData.Field_spellid_3.ToString();
            mainForm.myTextBox49.Text = MyData.Field_spellcategorycooldown_4.ToString();
            mainForm.myTextBox50.Text = MyData.Field_spellcategory_4.ToString();
            mainForm.myTextBox51.Text = MyData.Field_spellcooldown_4.ToString();
            mainForm.myTextBox52.Text = MyData.Field_spellppmRate_4.ToString();
            mainForm.myTextBox53.Text = MyData.Field_spellcharges_4.ToString();
            mainForm.myTextBox54.Text = MyData.Field_spellid_4.ToString();
            mainForm.myTextBox55.Text = MyData.Field_spellcategorycooldown_5.ToString();
            mainForm.myTextBox56.Text = MyData.Field_spellcategory_5.ToString();
            mainForm.myTextBox57.Text = MyData.Field_spellcooldown_5.ToString();
            mainForm.myTextBox58.Text = MyData.Field_spellppmRate_5.ToString();
            mainForm.myTextBox59.Text = MyData.Field_spellcharges_5.ToString();
            mainForm.myTextBox60.Text = MyData.Field_spellid_5.ToString();
            mainForm.myTextBox61.Text = MyData.Field_socketContent_1.ToString();
            mainForm.myTextBox62.Text = MyData.Field_socketContent_2.ToString();
            mainForm.myTextBox63.Text = MyData.Field_socketContent_3.ToString();
            mainForm.myTextBox64.Text = MyData.Field_block.ToString();
            mainForm.myTextBox65.Text = MyData.Field_armor.ToString();
            mainForm.myTextBox66.Text = MyData.Field_ArmorDamageModifier.ToString();
            mainForm.myTextBox67.Text = MyData.Field_MaxDurability.ToString();
            mainForm.myTextBox68.Text = MyData.Field_ContainerSlots.ToString();

            // COMBOBOX
            mainForm.comboBox1.SelectedIndex = mainForm.comboBox1.FindString(string.Format("[{0}]", MyData.Field_Quality));
            mainForm.comboBox2.SelectedIndex = mainForm.comboBox2.FindString(string.Format("[{0}]", MyData.Field_bonding));
            mainForm.comboBox3.SelectedIndex = mainForm.comboBox3.FindString(string.Format("[{0}]", MyData.Field_sheath));
            mainForm.comboBox4.SelectedIndex = mainForm.comboBox4.FindString(string.Format("[{0}]", MyData.Field_class));
            mainForm.comboBox5.SelectedIndex = mainForm.comboBox5.FindString(string.Format("[{0}]", MyData.Field_subclass));
            mainForm.comboBox6.SelectedIndex = mainForm.comboBox6.FindString(string.Format("[{0}]", MyData.Field_InventoryType));
            mainForm.comboBox7.SelectedIndex = mainForm.comboBox7.FindString(string.Format("[{0}]", MyData.Field_stat_type1));
            mainForm.comboBox8.SelectedIndex = mainForm.comboBox8.FindString(string.Format("[{0}]", MyData.Field_stat_type2));
            mainForm.comboBox9.SelectedIndex = mainForm.comboBox9.FindString(string.Format("[{0}]", MyData.Field_stat_type3));
            mainForm.comboBox10.SelectedIndex = mainForm.comboBox10.FindString(string.Format("[{0}]", MyData.Field_stat_type4));
            mainForm.comboBox11.SelectedIndex = mainForm.comboBox11.FindString(string.Format("[{0}]", MyData.Field_stat_type5));
            mainForm.comboBox12.SelectedIndex = mainForm.comboBox12.FindString(string.Format("[{0}]", MyData.Field_stat_type6));
            mainForm.comboBox13.SelectedIndex = mainForm.comboBox13.FindString(string.Format("[{0}]", MyData.Field_stat_type7));
            mainForm.comboBox14.SelectedIndex = mainForm.comboBox14.FindString(string.Format("[{0}]", MyData.Field_stat_type8));
            mainForm.comboBox15.SelectedIndex = mainForm.comboBox15.FindString(string.Format("[{0}]", MyData.Field_stat_type9));
            mainForm.comboBox16.SelectedIndex = mainForm.comboBox16.FindString(string.Format("[{0}]", MyData.Field_stat_type10));
            mainForm.comboBox17.SelectedIndex = mainForm.comboBox17.FindString(string.Format("[{0}]", MyData.Field_dmg_type1));
            mainForm.comboBox18.SelectedIndex = mainForm.comboBox18.FindString(string.Format("[{0}]", MyData.Field_dmg_type2));
            mainForm.comboBox19.SelectedIndex = mainForm.comboBox19.FindString(string.Format("[{0}]", MyData.Field_ammo_type));
            mainForm.cb_item_material.SelectedIndex = mainForm.cb_item_material.FindString(string.Format("[{0}]", MyData.Field_Material)); // [-1] consumable at index 0
            mainForm.comboBox21.SelectedIndex = mainForm.comboBox21.FindString(string.Format("[{0}]", MyData.Field_FoodType));
            mainForm.comboBox22.SelectedIndex = mainForm.comboBox22.FindString(string.Format("[{0}]", MyData.Field_TotemCategory));
            mainForm.comboBox23.SelectedIndex = mainForm.comboBox23.FindString(string.Format("[{0}]", MyData.Field_spelltrigger_1));
            mainForm.comboBox24.SelectedIndex = mainForm.comboBox24.FindString(string.Format("[{0}]", MyData.Field_spelltrigger_2));
            mainForm.comboBox25.SelectedIndex = mainForm.comboBox25.FindString(string.Format("[{0}]", MyData.Field_spelltrigger_3));
            mainForm.comboBox26.SelectedIndex = mainForm.comboBox26.FindString(string.Format("[{0}]", MyData.Field_spelltrigger_4));
            mainForm.comboBox27.SelectedIndex = mainForm.comboBox27.FindString(string.Format("[{0}]", MyData.Field_spelltrigger_5));
            mainForm.comboBox28.SelectedIndex = mainForm.comboBox28.FindString(string.Format("[{0}]", MyData.Field_socketColor_1));
            mainForm.comboBox29.SelectedIndex = mainForm.comboBox29.FindString(string.Format("[{0}]", MyData.Field_socketColor_2));
            mainForm.comboBox30.SelectedIndex = mainForm.comboBox30.FindString(string.Format("[{0}]", MyData.Field_socketColor_3));
            mainForm.comboBox31.SelectedIndex = mainForm.comboBox31.FindString(string.Format("[{0}]", MyData.Field_socketBonus));

            preLoadTemplate = false;
        }
    }
}
