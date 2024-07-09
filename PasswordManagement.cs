namespace Password_Management
{
    // This Class has the Methodes to search and write the passwords in a CSV
    public class PasswordSaveWrite
    {
        List<string> website = new List<string>();
        List<string> passwords = new List<string>();
        List<List<string>> lists = new List<List<string>>();
        public PasswordSaveWrite()
        {
            lists.Add(website);
            lists.Add(passwords);
        }
        public void setLists(List<List<string>> lists)
        {
            this.lists = lists;
        }

        public int getLength()
        {
            return lists.ElementAt(0).Count;
        }
        public void addNewPassWeb(string Website, string pass)
        {
            this.lists.ElementAt(0).Add(Website);
            this.lists.ElementAt(1).Add(pass);
        }
        public void changePass (string website, string pass, string filePath)
        {
            passwords = lists.ElementAt(1);
            int Count = 0;
            foreach (var item in lists.ElementAt(0))
            {
                if (item.ToLower() == website.ToLower())
                {
                    passwords[Count]= pass;
                    break;
                }
                Count++;
            }
            this.lists[1] = passwords;
            WriteDataToTxt(filePath, 0, false);
        }
        public string SearchPass(string website, string filePath)
        {
            int Count = 0;
            getData(filePath);
            foreach (string item in lists.ElementAt(0))
            {
                if (item.ToLower() == website.ToLower())
                {
                    return lists[1].ElementAt(Count);
                }
                Count++;
            }
            return " ";
        }
        // Diese Methode gibt alle Gepsiecherten Passwörter aus
        public void showPass()
        {
            string ausgabe = "";
            for (int i = 0; i < lists.ElementAt(0).Count; i++)
            {
                ausgabe += lists.ElementAt(0).ElementAt(i) + "\n" + lists.ElementAt(1).ElementAt(i) + "\n";

            }
            MessageBox.Show(ausgabe);
        }

        public string GetTextBoxContent(TextBox textBox)
        {
            return textBox.Text;
        }
        public void WriteDataToTxt(string filePath, int startingPoint, bool noChange)
        {
            StreamWriter writer = new StreamWriter(filePath, noChange);

            for (int i = startingPoint; i < lists.ElementAt(0).Count; i++)
            {
                writer.WriteLine(lists.ElementAt(0).ElementAt(i));
                writer.WriteLine(lists.ElementAt(1).ElementAt(i));
            }
            writer.Close();
        }

        public List<List<String>> getData(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Textdokument einlesen
                StreamReader reader = new StreamReader(filePath);
                // Zeilenweise lesen und ausgeben
                string line;
                bool flag=true;
                while ((line = reader.ReadLine()) != null)
                {  
                    if (flag)
                    {
                        // Add Webiste Data
                        lists.ElementAt(0).Add(line);
                        flag = false;
                    }else
                    {
                        // Addd Password Data
                        lists.ElementAt(1).Add(line);
                        flag = true;
                    }
                    //MessageBox.Show(line);
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Das Textdokument existiert nicht.");
            }
            return this.lists;
        }
    }


}