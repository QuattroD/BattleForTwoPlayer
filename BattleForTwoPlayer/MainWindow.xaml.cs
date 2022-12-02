using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleForTwoPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<FighterModelFirstPlayer> fighters = new List<FighterModelFirstPlayer>();
        public List<string> fightersName = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void StrengthMinus_Click(object sender, RoutedEventArgs e)
        {
            if(Strength.Text == "0")
            {              
                return;
            }
            else
            {
                FreePoints.Text = $"{int.Parse(FreePoints.Text) + 1}";
                Strength.Text = $"{int.Parse(Strength.Text) - 1}";
                pAttackValue.Text = $"{int.Parse(pAttackValue.Text) - 1}";
            }
        }

        private void DexterityMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Dexterity.Text == "0")
            {
                return;
            }
            else
            {
                FreePoints.Text = $"{int.Parse(FreePoints.Text) + 1}";
                Dexterity.Text = $"{int.Parse(Dexterity.Text) - 1}";
            }
        }

        private void LuckMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Luck.Text == "0")
            {
                return;
            }
            else
            {
                FreePoints.Text = $"{int.Parse(FreePoints.Text) + 1}";
                Luck.Text = $"{int.Parse(Luck.Text) - 1}";
            }
        }

        private void ConstitutionMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Constitution.Text == "0")
            {
                return;
            }
            else
            {
                FreePoints.Text = $"{int.Parse(FreePoints.Text) + 1}";
                Constitution.Text = $"{int.Parse(Constitution.Text) - 1}";
                hpValue.Text = $"{int.Parse(hpValue.Text) - 5}";
            }
        }

        private void IntelligenceMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Intteligence.Text == "0")
            {
                return;
            }
            else
            {
                FreePoints.Text = $"{int.Parse(FreePoints.Text) + 1}";
                Intteligence.Text = $"{int.Parse(Intteligence.Text) - 1}";
                manaValue.Text = $"{int.Parse(manaValue.Text) - 7}";
                mAttackValue.Text = $"{int.Parse(mAttackValue.Text) - 1}";
            }
        }

        private void StrengthPlus_Click(object sender, RoutedEventArgs e)
        {
            if (FreePoints.Text == "0")
            {
                return;
            }
            else
            {
                Strength.Text = $"{int.Parse(Strength.Text) + 1}";
                FreePoints.Text = $"{int.Parse(FreePoints.Text) - 1}";
                pAttackValue.Text = $"{int.Parse(pAttackValue.Text) + 1}";
            }
        }

        private void DexterityPlus_Click(object sender, RoutedEventArgs e)
        {
            if (FreePoints.Text == "0")
            {
                return;
            }
            else
            {
                Dexterity.Text = $"{int.Parse(Dexterity.Text) + 1}";
                FreePoints.Text = $"{int.Parse(FreePoints.Text) - 1}";
            }
        }

        private void LuckPlus_Click(object sender, RoutedEventArgs e)
        {
            if (FreePoints.Text == "0")
            {
                return;
            }
            else
            {
                Luck.Text = $"{int.Parse(Luck.Text) + 1}";
                FreePoints.Text = $"{int.Parse(FreePoints.Text) - 1}";
            }
        }

        private void ConstitutionPlus_Click(object sender, RoutedEventArgs e)
        {
            if (FreePoints.Text == "0")
            {
                return;
            }
            else
            {
                Constitution.Text = $"{int.Parse(Constitution.Text) + 1}";
                FreePoints.Text = $"{int.Parse(FreePoints.Text) - 1}";
                hpValue.Text = $"{int.Parse(hpValue.Text) + 5}";
            }
        }

        private void IntelligencePlus_Click(object sender, RoutedEventArgs e)
        {
            if (FreePoints.Text == "0")
            {
                return;
            }
            else
            {
                Intteligence.Text = $"{int.Parse(Intteligence.Text) + 1}";
                FreePoints.Text = $"{int.Parse(FreePoints.Text) - 1}";
                manaValue.Text = $"{int.Parse(manaValue.Text) + 7}";
                mAttackValue.Text = $"{int.Parse(mAttackValue.Text) + 1}";
            }
        }

        private void StrengthMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (StrengthSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + 1}";
                StrengthSecondPlayer.Text = $"{int.Parse(StrengthSecondPlayer.Text) - 1}";
                pAttackValueSecondPlayer.Text = $"{int.Parse(pAttackValueSecondPlayer.Text) - 1}";
            }
        }

        private void DexterityMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (DexteritySecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + 1}";
                DexteritySecondPlayer.Text = $"{int.Parse(DexteritySecondPlayer.Text) - 1}";
            }
        }

        private void LuckMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (LuckSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + 1}";
                LuckSecondPlayer.Text = $"{int.Parse(LuckSecondPlayer.Text) - 1}";
            }
        }

        private void ConstitutionMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (ConstitutionSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + 1}";
                ConstitutionSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) - 1}";
                hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) - 5}";
            }
        }

        private void IntelligenceMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (IntteligenceSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + 1}";
                IntteligenceSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) - 1}";
                manaValueSecondPlayer.Text = $"{int.Parse(manaValueSecondPlayer.Text) - 7}";
                mAttackValueSecondPlayer.Text = $"{int.Parse(mAttackValueSecondPlayer.Text) - 1}";
            }
        }

        private void StrengthPlusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (FreePointsSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                StrengthSecondPlayer.Text = $"{int.Parse(StrengthSecondPlayer.Text) + 1}";
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) - 1}";
                pAttackValueSecondPlayer.Text = $"{int.Parse(pAttackValueSecondPlayer.Text) + 1}";
            }
        }

        private void DexterityPlusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (FreePointsSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                DexteritySecondPlayer.Text = $"{int.Parse(DexteritySecondPlayer.Text) + 1}";
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) - 1}";
            }
        }

        private void LuckPlusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (FreePointsSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                LuckSecondPlayer.Text = $"{int.Parse(LuckSecondPlayer.Text) + 1}";
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) - 1}";
            }
        }

        private void ConstitutionPlusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (FreePointsSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                ConstitutionSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) + 1}";
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) - 1}";
                hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) + 5}";
            }
        }

        private void IntelligencePlusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (FreePointsSecondPlayer.Text == "0")
            {
                return;
            }
            else
            {
                IntteligenceSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) + 1}";
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) - 1}";
                manaValueSecondPlayer.Text = $"{int.Parse(manaValueSecondPlayer.Text) + 7}";
                mAttackValueSecondPlayer.Text = $"{int.Parse(mAttackValueSecondPlayer.Text) + 1}";
            }
        }

        public bool ReadyFirst { get; set; }
        public bool ReadySecond { get; set; }

        private void Ready2_Click(object sender, RoutedEventArgs e)
        {
            if (Ready2.Content.ToString() == "Ready")
            {
                NameSecondPlayer.IsEnabled = false;
                StrengthSecondPlayer.IsEnabled = false;
                DexteritySecondPlayer.IsEnabled = false;
                LuckSecondPlayer.IsEnabled = false;
                ConstitutionSecondPlayer.IsEnabled = false;
                IntteligenceSecondPlayer.IsEnabled = false;
                StrengthMinusSecondPlayer.IsEnabled = false;
                DexterityMinusSecondPlayer.IsEnabled = false;
                LuckMinusSecondPlayer.IsEnabled = false;
                ConstitutionMinusSecondPlayer.IsEnabled = false;
                IntelligenceMinusSecondPlayer.IsEnabled = false;
                StrengthPlusSecondPlayer.IsEnabled = false;
                DexterityPlusSecondPlayer.IsEnabled = false;
                LuckPlusSecondPlayer.IsEnabled = false;
                ConstitutionPlusSecondPlayer.IsEnabled = false;
                IntelligencePlusSecondPlayer.IsEnabled = false;
                crtValueSecondPlayer.Text = $"{(int.Parse(LuckSecondPlayer.Text) - int.Parse(Luck.Text) * 0.5) * 0.1}";
                evasionValueSecondPlayer.Text = $"{(int.Parse(DexteritySecondPlayer.Text) - int.Parse(Dexterity.Text)) * 0.1}";
                breakoutsValueSecondPlayer.Text = $"{(int.Parse(StrengthSecondPlayer.Text) - int.Parse(Strength.Text)) * 0.05}";
                Ready2.Content = "Unready";
                ReadySecond = true;
            }
            else if (Ready2.Content.ToString() == "Unready")
            {
                NameSecondPlayer.IsEnabled = true;
                StrengthSecondPlayer.IsEnabled = true;
                DexteritySecondPlayer.IsEnabled = true;
                LuckSecondPlayer.IsEnabled = true;
                ConstitutionSecondPlayer.IsEnabled = true;
                IntteligenceSecondPlayer.IsEnabled = true;
                StrengthMinusSecondPlayer.IsEnabled = true;
                DexterityMinusSecondPlayer.IsEnabled = true;
                LuckMinusSecondPlayer.IsEnabled = true;
                ConstitutionMinusSecondPlayer.IsEnabled = true;
                IntelligenceMinusSecondPlayer.IsEnabled = true;
                StrengthPlusSecondPlayer.IsEnabled = true;
                DexterityPlusSecondPlayer.IsEnabled = true;
                LuckPlusSecondPlayer.IsEnabled = true;
                ConstitutionPlusSecondPlayer.IsEnabled = true;
                IntelligencePlusSecondPlayer.IsEnabled = true;
                Ready2.Content = "Ready";
                ReadySecond = false;
            }
            
            if(ReadyFirst == true && ReadySecond == true)
            {
                FightB.IsEnabled = true;
            }
            else
            {
                FightB.IsEnabled = false;
            }
        }       

        private void Ready1_Click(object sender, RoutedEventArgs e)
        {
            List<FighterModelFirstPlayer> fighters = new List<FighterModelFirstPlayer>();
            List<string> fightersName = new List<string>();
            if (Ready1.Content.ToString() == "Ready")
            {
                Name.IsEnabled = false;
                Strength.IsEnabled = false;
                Dexterity.IsEnabled = false;
                Luck.IsEnabled = false;
                Constitution.IsEnabled = false;
                Intteligence.IsEnabled = false;
                StrengthMinus.IsEnabled = false;
                DexterityMinus.IsEnabled = false;
                LuckMinus.IsEnabled = false;
                ConstitutionMinus.IsEnabled = false;
                IntelligenceMinus.IsEnabled = false;
                StrengthPlus.IsEnabled = false;
                DexterityPlus.IsEnabled = false;
                LuckPlus.IsEnabled = false;
                ConstitutionPlus.IsEnabled = false;
                IntelligencePlus.IsEnabled = false;
                crtValue.Text = $"{(int.Parse(Luck.Text) - int.Parse(LuckSecondPlayer.Text) * 0.5) * 0.1}";
                evasionValue.Text = $"{(int.Parse(Dexterity.Text) - int.Parse(DexteritySecondPlayer.Text)) * 0.1}";
                breakoutsValue.Text = $"{(int.Parse(Strength.Text) - int.Parse(StrengthSecondPlayer.Text)) * 0.05}";
                Ready1.Content = "Unready";
                ReadyFirst = true;
                FighterModelFirstPlayer fighter = new FighterModelFirstPlayer(Name.Text, int.Parse(lvlValue.Text), int.Parse(Strength.Text), int.Parse(Dexterity.Text), int.Parse(Luck.Text), int.Parse(Constitution.Text), int.Parse(Intteligence.Text));
                fighters.Add(fighter);
                fightersName.Add(Name.Text);
                Units.ItemsSource = fightersName;
            }
            else if (Ready1.Content.ToString() == "Unready")
            {
                Name.IsEnabled = true;
                Strength.IsEnabled = true;
                Dexterity.IsEnabled = true;
                Luck.IsEnabled = true;
                Constitution.IsEnabled = true;
                Intteligence.IsEnabled = true;
                StrengthMinus.IsEnabled = true;
                DexterityMinus.IsEnabled = true;
                LuckMinus.IsEnabled = true;
                ConstitutionMinus.IsEnabled = true;
                IntelligenceMinus.IsEnabled = true;
                StrengthPlus.IsEnabled = true;
                DexterityPlus.IsEnabled = true;
                LuckPlus.IsEnabled = true;
                ConstitutionPlus.IsEnabled = true;
                IntelligencePlus.IsEnabled = true;
                Ready1.Content = "Ready";
                ReadyFirst = false;
            }
            

            if (ReadyFirst == true && ReadySecond == true)
            {
                FightB.IsEnabled = true;
            }
            else
            {
                FightB.IsEnabled = false;
            }
        }

        private void Units_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(var item in fighters)
            {
                if (Units.SelectedValue.ToString() == item.Name)
                {
                    Name.Text = item.Name;
                    Strength.Text = item.Strength.ToString();
                    Dexterity.Text = item.Dexterity.ToString();
                    Luck.Text = item.Luck.ToString();
                    Constitution.Text = item.Constitution.ToString();
                    Intteligence.Text = item.Intelligence.ToString();
                    lvlValue.Text = item.LVL.ToString();

                }
            }
        }
    }
}
