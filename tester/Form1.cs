namespace tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var file_br = "BR (BR).txt";
            var file_cl = "CL (CL).txt";
            var file_eu = "Eu (Eu).txt";
            var file_gz = "GAZR (GZ).txt";
            var file_gk = "GMKN (GK).txt";
            var file_gd = "GOLD (GD).txt";
            var file_hy = "HYDR (HY).txt";
            var file_lk = "LKOH (LK).txt";
            var file_mx = "MIX (MX).txt";
            var file_rn = "ROSN (RN).txt";
            var file_ri = "RTS (RI).txt";
            var file_sp = "SBPR (SP).txt";
            var file_sr = "SBRF (SR).txt";
            var file_si = "Si (Si).txt";
            var file_sv = "SILV (SV).txt";
            var file_sn = "SNGR (SN).txt";
            var file_vb = "VTBR (VB).txt";
            

            var path_br = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_br}";
            var path_cl = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_cl}";
            var path_eu = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_eu}";
            var path_gz = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_gz}";
            var path_gk = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_gk}";
            var path_gd = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_gd}";
            var path_hy = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_hy}";
            var path_lk = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_lk}";
            var path_mx = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_mx}";
            var path_rn = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_rn}";
            var path_ri = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_ri}";
            var path_sp = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_sp}";
            var path_sr = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_sr}";
            var path_si = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_si}";
            var path_sv = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_sv}";
            var path_sn = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_sn}";
            var path_vb = $"C:\\Users\\79169\\Desktop\\FinamDownload\\date\\{file_vb}";
            

            if (!File.Exists(path_br)) { return; }
            try
            {
                var reader = new StreamReader(path_br);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\br\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_cl)) { return; }
            try
            {
                var reader = new StreamReader(path_cl);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\cl\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_eu)) { return; }
            try
            {
                var reader = new StreamReader(path_eu);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\eu\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_gz)) { return; }
            try
            {
                var reader = new StreamReader(path_gz);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\gz\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_gk)) { return; }
            try
            {
                var reader = new StreamReader(path_gk);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\gk\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_gd)) { return; }
            try
            {
                var reader = new StreamReader(path_gd);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\gd\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_hy)) { return; }
            try
            {
                var reader = new StreamReader(path_hy);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\hy\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_lk)) { return; }
            try
            {
                var reader = new StreamReader(path_lk);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\lk\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_mx)) { return; }
            try
            {
                var reader = new StreamReader(path_mx);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\mx\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_rn)) { return; }
            try
            {
                var reader = new StreamReader(path_rn);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\rn\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_ri)) { return; }
            try
            {
                var reader = new StreamReader(path_ri);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\ri\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sp)) { return; }
            try
            {
                var reader = new StreamReader(path_sp);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\sp\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sr)) { return; }
            try
            {
                var reader = new StreamReader(path_sr);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\sr\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_si)) { return; }
            try
            {
                var reader = new StreamReader(path_si);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\si\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sv)) { return; }
            try
            {
                var reader = new StreamReader(path_sv);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\sv\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sn)) { return; }
            try
            {
                var reader = new StreamReader(path_sn);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\sn\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_vb)) { return; }
            try
            {
                var reader = new StreamReader(path_vb);
                var line = "";
                line = reader.ReadLine();
                string datefirst = "";
                string filename = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');
                        var DATA = str[0];
                        if (datefirst != DATA)
                        {
                            datefirst = DATA;
                            filename = $"{datefirst}.txt";
                        }
                        var writer = new StreamWriter("C:\\Users\\79169\\Documents\\Projects\\tester\\tester\\tester\\date\\vb\\" + filename, true);//true для дозаписи,false для перезаписи
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
        }           

        public Dictionary<string, decimal> Go_br = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_cl = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_eu = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_gz = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_gk = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_gd = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_hy = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_lk = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_mx = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_rn = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_ri = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_sp = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_sr = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_si = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_sv = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_sn = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Go_vb = new Dictionary<string, decimal>();
        private void LoadGO()
        {
            var file_br = "BR.txt";
            var path_br = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_br}";
            var file_cl = "CL.txt";
            var path_cl = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_cl}";
            var file_eu = "Eu.txt";
            var path_eu = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_eu}";
            var file_gz = "GZ.txt";
            var path_gz = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_gz}";
            var file_gk = "GK.txt";
            var path_gk = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_gk}";
            var file_gd = "GD.txt";
            var path_gd = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_gd}";
            var file_hy = "HY.txt";
            var path_hy = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_hy}";
            var file_lk = "LK.txt";
            var path_lk = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_lk}";
            var file_mx = "MX.txt";
            var path_mx = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_mx}";
            var file_rn = "RN.txt";
            var path_rn = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_rn}";
            var file_ri = "RI.txt";
            var path_ri = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_ri}";
            var file_sp = "SP.txt";
            var path_sp = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_sp}";
            var file_sr = "SR.txt";
            var path_sr = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_sr}";
            var file_si = "Si.txt";
            var path_si = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_si}";
            var file_sv = "SV.txt";
            var path_sv = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_sv}";
            var file_sn = "SN.txt";
            var path_sn = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_sn}";
            var file_vb = "VB.txt";
            var path_vb = $"C:\\Users\\79169\\Desktop\\FinamDownload\\go\\{file_vb}";
            
            if (!File.Exists(path_br)) { return; }                        
            try
            {
                var reader = new StreamReader(path_br);
                var line = "";
                line = reader.ReadLine();
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_br[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_cl)) { return; }
            try
            {
                var reader = new StreamReader(path_cl);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_cl[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_eu)) { return; }
            try
            {
                var reader = new StreamReader(path_eu);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_eu[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_gz)) { return; }
            try
            {
                var reader = new StreamReader(path_gz);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_gz[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_gk)) { return; }
            try
            {
                var reader = new StreamReader(path_gk);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_gk[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_gd)) { return; }
            try
            {
                var reader = new StreamReader(path_gd);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_gd[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_hy)) { return; }
            try
            {
                var reader = new StreamReader(path_hy);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_hy[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_lk)) { return; }
            try
            {
                var reader = new StreamReader(path_lk);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_lk[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_mx)) { return; }
            try
            {
                var reader = new StreamReader(path_mx);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_mx[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_rn)) { return; }
            try
            {
                var reader = new StreamReader(path_rn);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_rn[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_ri)) { return; }
            try
            {
                var reader = new StreamReader(path_ri);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_ri[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sp)) { return; }
            try
            {
                var reader = new StreamReader(path_sp);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_sp[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sr)) { return; }
            try
            {
                var reader = new StreamReader(path_sr);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_sr[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_si)) { return; }
            try
            {
                var reader = new StreamReader(path_si);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_si[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sv)) { return; }
            try
            {
                var reader = new StreamReader(path_sv);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_sv[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_sn)) { return; }
            try
            {
                var reader = new StreamReader(path_sn);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_sn[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (!File.Exists(path_vb)) { return; }
            try
            {
                var reader = new StreamReader(path_vb);
                var line = "";
                line = reader.ReadLine();

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var str = line.Split(',');

                        if (str.Length > 10 && !string.IsNullOrEmpty(str[10]))
                        {
                            var date = str[2];
                            var go = Convert.ToDecimal(str[10]);

                            if (go > 0)
                            {
                                Go_vb[date] = go;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
        }
        private void DisplayMessageBoxText()
        {
            MessageBox.Show("Обновление завершено");
        }
    }
}