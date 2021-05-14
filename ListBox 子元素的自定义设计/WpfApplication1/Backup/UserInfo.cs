using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace ListBoxStyling
{
    public class UserInfo
    {
        private string nameVal;

        public string Name
        {
            get { return nameVal; }
            set { nameVal = value; }
        }

        private string imagePathVal;

        public string ImagePath
        {
            get { return imagePathVal; }
            set { imagePathVal = value; }
        }


        public override string ToString()
        {
            return Name;
        }

        public UserInfo(string name, string imagePath)
        {
            this.nameVal = name;
            this.imagePathVal = imagePath;
        }

        public static UserInfo[] Users =
        {
            new UserInfo("Arthur Alfredsen", "Images/airplane.bmp"),
            new UserInfo("Brenda Barret", "Images/astro.bmp"),
            new UserInfo("Carl Christiansen", "Images/beach.bmp"),
            new UserInfo("Delia Davis", "Images/butterfl.bmp"),
            new UserInfo("Egbert Evesham", "Images/car.bmp"),
            new UserInfo("Fenella Ferguson", "Images/cat.bmp"),
            new UserInfo("Graham Garden", "Images/chess.bmp"),
            new UserInfo("Hilary Humperdinck", "Images/dirtbike.bmp"),
            new UserInfo("Ian Ingernook", "Images/dog.bmp"),
            new UserInfo("Joan Jackson", "Images/drip.bmp"),
            new UserInfo("Kevin Kostco", "Images/duck.bmp"),
            new UserInfo("Leah Limbert", "Images/fish.bmp"),
            new UserInfo("Marvin Masterson", "Images/frog.bmp"),
            new UserInfo("Nellie Norbert", "Images/guitar.bmp"),
            new UserInfo("Ollie Ogilvy", "Images/horses.bmp"),
            new UserInfo("Priscilla Peters", "Images/kick.bmp"),
            new UserInfo("Quentin Quasires", "Images/liftoff.bmp"),
            new UserInfo("Roberta Roberts", "Images/palmtree.bmp"),
            new UserInfo("Steve Stuart", "Images/pnkflowr.bmp"),
            new UserInfo("Teri Tobeson", "Images/redflowr.bmp"),
            new UserInfo("Ulysses Uhura", "Images/skater.bmp"),
            new UserInfo("Val Vignette", "Images/snwflake.bmp"),
            new UserInfo("William Watson", "Images/drip.bmp"),
            new UserInfo("Xanthe Xardos", "Images/user.bmp"),
            new UserInfo("Ybrahim Yavin", "Images/guest.bmp"),
            new UserInfo("Zaphod Zacharzewski", "images/soccer.bmp")
        };
    }
}
