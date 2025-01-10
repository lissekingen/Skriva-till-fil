FileStream fs =new FileStream(".txt",FileMode.Open,FileAccess.Read);
StreamReader sr = new StreamReader(fs);
string tjena = sr.ReadToEnd();
sr.Close();
Console.WriteLine(tjena);
