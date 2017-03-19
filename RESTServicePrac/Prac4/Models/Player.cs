using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Prac4.Models
{
    public class Player
    {
        [Required]
        public String RegistrationID { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String TeamName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public Player()
        {

        }
        public Player(String rid, String fn, String ln, String tn, DateTime dob)
        {
            this.RegistrationID = rid;
            this.FirstName = fn;
            this.LastName = ln;
            this.TeamName = tn;
            this.DateOfBirth = dob;
        }

        public static string PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "players.txt");
        public static List<Player> GetAllPlayers()
        {
            try
            {
                List<Player> retList = new List<Player>();
                using (StreamReader sr = new StreamReader(Player.PATH))
                {
                    int count = 1;
                    string lineText;
                    while ((lineText = sr.ReadLine()) != null)
                    {
                        String[] attr = lineText.Split(',');
                        DateTime dob = Convert.ToDateTime(attr[4]);
                        Player p = new Player(attr[0], attr[1], attr[2], attr[3], dob);
                        retList.Add(p);
                    }
                    return retList;
                }
            }
            catch (Exception e)
            {
                return new List<Player>();
            }
        }

        public bool SaveToFile()
        {
            try
            {
                StringBuilder text = new StringBuilder();
                String[] AllLines = File.ReadAllLines(Player.PATH);
                Boolean Update = false; 
                for (int i = 0; i < AllLines.Count(); i++)
                {
                    String currentLine = AllLines[i];
                    String currentId = currentLine.Split(',').First();
                    Update = (this.RegistrationID == currentId);

                    if (i == 0)
                    {
                        // if it is the first line to append, do not change line
                        text.Append(Update ? this.ToString() : currentLine);
                    }
                    else
                    {
                        text.Append("\r\n" + (Update ? this.ToString() : currentLine));
                    }
                }
                if (!Update) text.Append("\r\n" + this.ToString());
                File.WriteAllText(Player.PATH, text.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        /// <summary>
        /// This Function Updates Files With New Player List
        /// </summary>
        /// <returns></returns>
        public static bool UpdateFile(List<Player> pList)
        {
            try
            {
                StringBuilder text = new StringBuilder();
                for (int i = 0; i < pList.Count; i++)
                {
                    Player p = pList[i];
                    text.Append((i == 0 ? "" : "\r\n") + p.ToString());
                }
                File.WriteAllText(Player.PATH, text.ToString());
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.RegistrationID.ToStr() + ',' + this.FirstName.ToStr() + ',' + this.LastName.ToStr() + ',' + this.TeamName.ToStr() + ',' + this.DateOfBirth.ToString("yyyy-MM-dd");
        }
    }
}