using MySql.Data.MySqlClient;
//Проба git

namespace Poiskfile
{
    public partial class Form1 : Form
    {
        List<Meteorecord> Meteo;

        string[] allFoundFiles;
        string textl, texto;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void loadpathdir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string filetext = folderBrowserDialog1.SelectedPath;
                textl = filetext;
                textBoxload.Text = filetext;
                allFoundFiles = Directory.GetFiles(filetext);
            }
        }

        private void outpathdir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string filetext = folderBrowserDialog1.SelectedPath;
                texto = filetext;
                textBoxout.Text = filetext;
            }
        }

        private void loadlistgms_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".csv")
                {
                    richTextBoxGMS.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                {
                    richTextBoxGMS.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string serverName = txtbxServer.Text;
            //string userName = txtbxLogin.Text;
            //string dbName = txtbxDB.Text;
            //string port = txtbxPort.Text;
            //string password = txtbxPassword.Text;
            //string connStr = "server=" + serverName +
            //    ";user=" + userName +
            //    ";database=" + dbName +
            //    ";port=" + port +
            //    ";password=" + password + ";";
            //conn = new MySqlConnection(connStr);
            //conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string serverName = txtbxServer.Text;
            string userName = txtbxLogin.Text;
            string dbName = txtbxDB.Text;
            string port = txtbxPort.Text;
            string password = txtbxPassword.Text;
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            conn = new MySqlConnection(connStr);
            conn.Open();



            string sql = "INSERT INTO meteonasa (datep, wnd1) values ('2022-10-01 12:12:01',1)"; // Строка запроса
            MySqlCommand cmd1 = new MySqlCommand(sql, conn);
            cmd1.ExecuteReader();

            conn.Close();

     
           
            conn = new MySqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM meteonasa limit 100"; // Строка запроса
            MySqlCommand  cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtbxSQL.Text += reader["wnd1"];
            }

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            MySqlConnection conn;
            string serverName = txtbxServer.Text;
            string userName = txtbxLogin.Text;
            string dbName = txtbxDB.Text;
            string port = txtbxPort.Text;
            string password = txtbxPassword.Text;
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            conn = new MySqlConnection(connStr);
            conn.Open();



         

            

            foreach (string file in allFoundFiles)
            {
                int indexToText = richTextBoxGMS.Find(Path.GetFileName(file));

                if (indexToText >= 0)
                {
                    Meteo =  new List<Meteorecord>();
                    string fName = file.Substring(textl.Length + 1);
                    File.Copy(file, Path.Combine(texto, fName), true);

                    string str = string.Empty;
                    textBox1.Text = "";

                    using (System.IO.StreamReader reader = System.IO.File.OpenText(Path.Combine(texto, fName)))
                    {
                        str = reader.ReadToEnd();
                        //To repair csv to norval translate metadata. Format view as: "value","value","value" and etc
                        str = str.Replace("\"", "");
                        str = str.Replace(",", "\",\"");
                        str = str.Replace($"099999", "");
                        string[] subs = str.Split("\n");
                        //
                        var countRecord = 0;
                        foreach (string line in subs)
                        {
                           if (countRecord >0) 
                                try
                                {
                                    var station = int.Parse(line.Split("\u0022,\u0022")[0]); //STATION
                                    var dates = line.Split("\u0022,\u0022")[1].Replace("T", " ");  //DATE
                                    var wnd1 = int.Parse(line.Split("\u0022,\u0022")[11]); //WND(1)
                                    var wnd2 = int.Parse(line.Split("\u0022,\u0022")[12]); //WND(2)
                                    var wnd3 = line.Split("\u0022,\u0022")[13]; //WND(3)
                                    var wnd4 = int.Parse(line.Split("\u0022,\u0022")[14]); //WND(4)
                                    var wnd5 = int.Parse(line.Split("\u0022,\u0022")[15]); //WND(5)
                                    var tmp1 = int.Parse(line.Split("\u0022,\u0022")[24]); //TMP(1)
                                    var tmp2 = line.Split("\u0022,\u0022")[25]; //TMP(2)
                                    var dew1 = int.Parse(line.Split("\u0022,\u0022")[26]); //DEW(1)
                                    var dew2 = line.Split("\u0022,\u0022")[27]; //DEW(2)
                                    var aa1 =  line.Split("\u0022,\u0022")[30]; //AA1(1)
                                    var aa2 =  line.Split("\u0022,\u0022")[31]; //AA1(1)
                                    var aa3 =  line.Split("\u0022,\u0022")[32]; //AA1(3)
                                    var aa4 =  line.Split("\u0022,\u0022")[33]; //AA1(4)
                                    Meteo.Add(new Meteorecord(station, dates, wnd1, wnd2, wnd3, wnd4,wnd5, tmp1, tmp2, dew1, dew2, aa1, aa2, aa3, aa4));
                                } catch 
                                {
                                    MessageBox.Show("Значение строки line:"+line+":");
                                };
             

                            countRecord++;
                           
                        }
                    }
                    using (System.IO.StreamWriter filee = new System.IO.StreamWriter(Path.Combine(texto, fName)))
                    {
                        filee.Write(str);
                    }

                    MessageBox.Show("Всего элементов в массиве:" + Meteo.Count + ":");


                    for (int i = 0; i < Meteo.Count; i++)
                    {
                        conn = new MySqlConnection(connStr);
                        conn.Open();
                      

                        var aa11s = Meteo[i].Aa11 == "" ? "NULL" : Meteo[i].Aa11;
                        var aa12s = Meteo[i].Aa12 == "" ? "NULL" : Meteo[i].Aa12;
                     
                        var aa14s = Meteo[i].Aa14 == "" ? "NULL" : Meteo[i].Aa14;

                        string sql = $"INSERT INTO meteonasa (station,datep, wnd1,wnd2,wnd3,wnd4,wnd5,tmp1,tmp2,dew1,dew2,aa11,aa12,aa13,aa14) values " +
                            $"(" +
                            $"{Meteo[i].Station}," +
                            $"'{Meteo[i].Dates}'," +
                            $"{Meteo[i].Wnd1}," +
                            $"{Meteo[i].Wnd2}," +
                            $"'{Meteo[i].Wnd3}'," +
                            $"{Meteo[i].Wnd4}," +
                            $"{Meteo[i].Wnd5}," +
                            $"{Meteo[i].Tmp1}," +
                            $"'{Meteo[i].Tmp2}'," +
                            $"{Meteo[i].Dew1}," +
                            $"'{Meteo[i].Dew2}'," +
                            $"{aa11s}," +
                            $"{aa12s}," +
                            $"'{Meteo[i].Aa13}'," +
                            $"{aa14s})"; // Строка запроса
                        //MessageBox.Show("Проверка запроса: " + sql);
                        MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                        cmd1.ExecuteReader();
                        conn.Close();
                    }
                    


                }
               // MessageBox.Show("Проверка файла: "+ Path.GetFileName(file));
            }
        }
    }
}
//POS: 16 - 23
//                GEOPHYSICAL - POINT - OBSERVATION date
//                The date of a GEOPHYSICAL-POINT-OBSERVATION. 
//                MIN:  00000101     MAX: 99991231
//                DOM: A general domain comprised of integer values 0-9 in the format YYYYMMDD. 
//                YYYY can be any positive integer value; MM is restricted to values 01 - 12; and DD is restricted  
//                to values 01-31. 
 
//POS: 24 - 27
//                GEOPHYSICAL - POINT - OBSERVATION time
//                The time of a GEOPHYSICAL-POINT-OBSERVATION based on  
//                Coordinated Universal Time Code (UTC). 
//                MIN: 0000         MAX: 2359
//                DOM: A general domain comprised of integer values 0-9 in the format HHMM. 
//                HH is restricted to values 00-23; MM is restricted to values 00 - 59.
//==========================================================================================================================
//POS: 61 - 63
//WIND - OBSERVATION direction angle 
//                The angle, measured in a clockwise direction, between true north and the direction from which 
//                the wind is blowing. 
//                MIN:  001          MAX: 360         UNITS: Angular Degrees
//                SCALING FACTOR:  1
//                DOM: A general domain comprised of the numeric characters (0-9). 
//                           999 = Missing.If type code(below) = V, then 999 indicates variable wind direction. 

//POS: 64 - 64
//                WIND - OBSERVATION direction quality code 
//                The code that denotes a quality status of a reported WIND-OBSERVATION direction angle. 
//                DOM:  A specific domain comprised of the characters in the ASCII character set. 
//                            0 = Passed gross limits check  
//                            1 = Passed all quality control checks 
//                            2 = Suspect 
//                            3 = Erroneous 
//                            4 = Passed gross limits check , data originate from an NCEI data source 
//                            5 = Passed all quality control checks, data originate from an NCEI data source 
//                            6 = Suspect, data originate from an NCEI data source 
//                            7 = Erroneous, data originate from an NCEI data source 
//            9 = Passed gross limits check if element is present 

//POS: 65 - 65
//                WIND - OBSERVATION type code 
//                The code that denotes the character of the WIND-OBSERVATION. 
//                DOM:  A specific domain comprised of the characters in the ASCII character set. 
//                           A: Abridged Beaufort 
//             B: Beaufort
//                           C: Calm
//             H: 5 - Minute Average Speed  
//                           N: Normal
//                           R: 60 - Minute Average Speed 
//                           Q: Squall
//                           T: 180 Minute Average Speed 
//                           V: Variable
//                           9 = Missing
//                NOTE: If a value of 9 appears with a wind speed of 0000, this indicates calm winds. 

//POS: 66 - 69
//                WIND - OBSERVATION speed rate 
//                The rate of horizontal travel of air past a fixed point. 



//  8 
//                MIN:  0000        MAX: 0900       UNITS: meters per second
//                SCALING FACTOR:  10
//                DOM: A general domain comprised of the numeric characters (0-9). 
//                            9999 = Missing.

//POS: 70 - 70
//                WIND - OBSERVATION speed quality code 
//                The code that denotes a quality status of a reported WIND-OBSERVATION speed rate. 
//                DOM:  A specific domain comprised of the characters in the ASCII character set. 
//                            0 = Passed gross limits check  
//                            1 = Passed all quality control checks 
//                            2 = Suspect 
//                            3 = Erroneous 
//                            4 = Passed gross limits check , data originate from an NCEI data source 
//                            5 = Passed all quality control checks, data originate from an NCEI data source 
//                            6 = Suspect, data originate from an NCEI data source 
//                            7 = Erroneous, data originate from an NCEI data source 
//                            9 = Passed gross limits check if element is present 
//================================================================================================================
//POS: 88 - 92
//                AIR - TEMPERATURE - OBSERVATION air temperature 
//                The temperature of the air. 
//                MIN:  -0932       MAX: +0618        UNITS: Degrees Celsius
//                SCALING FACTOR:  10
//                DOM: A general domain comprised of the numeric characters (0-9), a plus sign (+), and a minus 
//                                          sign (-). 



//  10
//                                          + 9999 = Missing.

//POS: 93 - 93
//                AIR - TEMPERATURE - OBSERVATION air temperature quality code 
//                The code that denotes a quality status of an AIR-TEMPERATURE-OBSERVATION. 
//                DOM:  A specific domain comprised of the characters in the ASCII character set. 
//                            0 = Passed gross limits check  
//                            1 = Passed all quality control checks 
//                            2 = Suspect 
//                            3 = Erroneous 
//                            4 = Passed gross limits check , data originate from an NCEI data source 
//                            5 = Passed all quality control checks, data originate from an NCEI data source 
//                            6 = Suspect, data originate from an NCEI data source 
//                            7 = Erroneous, data originate from an NCEI data source 
//            9 = Passed gross limits check if element is present 
//           A = Data value flagged as suspect, but accepted as a good value 
//           C = Temperature and dew point received from Automated Weather Observing System (AWOS) are reported in         
//                  whole degrees Celsius. Automated QC flags these values, but they are accepted as valid. 
//           I = Data value not originally in data, but inserted by validator 
//           M = Manual changes made to value based on information provided by NWS or FAA 
//           P = Data value not originally flagged as suspect, but replaced by validator 
//           R = Data value replaced with value computed by NCEI software 
//           U = Data value replaced with edited value  
//==============================================================================================================
//POS: 94 - 98
//                AIR - TEMPERATURE - OBSERVATION dew point temperature 
//                The temperature to which a given parcel of air must be cooled at constant pressure and water vapor 
//                content in order for saturation to occur. 
//                MIN:  -0982       MAX: +0368        UNITS: Degrees Celsius
//                SCALING FACTOR:  10
//                DOM: A general domain comprised of the numeric characters (0-9), a plus 
//                           sign (+), and a minus sign (-). 
//                          +9999 = Missing.


//POS: 99 - 99
//                AIR - TEMPERATURE - OBSERVATION dew point quality code 
//                The code that denotes a quality status of the reported dew point temperature. 
//                DOM:  A specific domain comprised of the characters in the ASCII character set. 
//                            0 = Passed gross limits check  
//                            1 = Passed all quality control checks 
//                            2 = Suspect 
//                            3 = Erroneous 
//                            4 = Passed gross limits check , data originate from an NCEI data source 
//                            5 = Passed all quality control checks, data originate from an NCEI data source 
//                            6 = Suspect, data originate from an NCEI data source 
//                            7 = Erroneous, data originate from an NCEI data source 
//            9 = Passed gross limits check if element is present 
//            A = Data value flagged as suspect, but accepted as a good value 
//           C = Temperature and dew point received from Automated Weather Observing System (AWOS) are reported in         
//                  whole degrees Celsius. Automated QC flags these values, but they are accepted as valid. 
//           I = Data value not originally in data, but inserted by validator 
//           M = Manual changes made to value based on information provided by NWS or FAA 
//           P = Data value not originally flagged as suspect, but replaced by validator 
//           R = Data value replaced with value computed by NCEI software 
//           U = Data value replaced with edited value  
