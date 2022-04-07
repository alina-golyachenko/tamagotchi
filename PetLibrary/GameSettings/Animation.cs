using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PetLibrary.GameSettings
{
    public class Animation
    {
        public static List<BitmapImage> RegularSprites { get; private set; }
        public static List<BitmapImage> TubeSprites { get; private set; }
        public static List<BitmapImage> SleepingSprites { get; private set; }
        public static List<BitmapImage> WorkingSprites { get; private set; }
        public static List<BitmapImage> GraveSprites { get; private set; }

        private static readonly string IconPath = new DirectoryInfo(Directory.GetCurrentDirectory()).FullName.ToString() + @"\Images\Menu";
        private static readonly string SpritePath = new DirectoryInfo(Directory.GetCurrentDirectory()).FullName.ToString() + @"\Images\Sprites";
        public static List<BitmapImage> DayMenu { get; private set; }
        public static List<BitmapImage> NightMenu { get; private set; }
        public static BitmapImage CurrentAnimation { get; set; }

        public Animation()
        {
            RegularSprites = new List<BitmapImage>();
            RegularSprites.Add(new BitmapImage(new Uri(SpritePath + @"\Regular\frontSheepRegular.png")));
            CurrentAnimation = RegularSprites[0];

            TubeSprites = new List<BitmapImage>();
            TubeSprites.Add(new BitmapImage(new Uri(SpritePath + @"\PlayingTube\tubeSheep1.png")));
            TubeSprites.Add(new BitmapImage(new Uri(SpritePath + @"\PlayingTube\tubeSheep2.png")));

            SleepingSprites = new List<BitmapImage>();
            SleepingSprites.Add(new BitmapImage(new Uri(SpritePath + @"\Sleeping\sleepSheep1.png")));
            SleepingSprites.Add(new BitmapImage(new Uri(SpritePath + @"\Sleeping\sleepSheep2.png")));
            SleepingSprites.Add(new BitmapImage(new Uri(SpritePath + @"\Sleeping\sleepSheep3.png")));

            WorkingSprites = new List<BitmapImage>();
            WorkingSprites.Add(new BitmapImage(new Uri(SpritePath + @"\Working\workingSheep.png")));

            GraveSprites = new List<BitmapImage>();
            GraveSprites.Add(new BitmapImage(new Uri(SpritePath + @"\Grave\grave.png")));

            DayMenu = new List<BitmapImage>();
            DayMenu.Add(new BitmapImage(new Uri(IconPath + @"\Day\satietyIconDay.png")));
            DayMenu.Add(new BitmapImage(new Uri(IconPath + @"\Day\energyIconDay.png")));
            DayMenu.Add(new BitmapImage(new Uri(IconPath + @"\Day\emotionsIconDay.png")));
            DayMenu.Add(new BitmapImage(new Uri(IconPath + @"\Day\healthIconDay.png")));
            DayMenu.Add(new BitmapImage(new Uri(IconPath + @"\Day\menuIconDay.png")));


            NightMenu = new List<BitmapImage>();
            NightMenu.Add(new BitmapImage(new Uri(IconPath + @"\Night\satietyIconNight.png")));
            NightMenu.Add(new BitmapImage(new Uri(IconPath + @"\Night\energyIconNight.png")));
            NightMenu.Add(new BitmapImage(new Uri(IconPath + @"\Night\emotionsIconNight.png")));
            NightMenu.Add(new BitmapImage(new Uri(IconPath + @"\Night\healthIconNight.png")));
            NightMenu.Add(new BitmapImage(new Uri(IconPath + @"\Night\menuIconNight.png")));
        }

        public BitmapImage Animate(BitmapImage currentSprite)
        {
            if (currentSprite == TubeSprites[0])
            {
                currentSprite = TubeSprites[1];
            }
            else if (currentSprite == TubeSprites[1])
            {
                currentSprite = TubeSprites[0];
            }

            if (currentSprite == SleepingSprites[0])
            {
                currentSprite = SleepingSprites[1];
            }
            else if (currentSprite == SleepingSprites[1])
            {
                currentSprite = SleepingSprites[2];
            }
            else if (currentSprite == SleepingSprites[2])
            {
                currentSprite = SleepingSprites[1];
            }


            return currentSprite;
        }
    }
}
