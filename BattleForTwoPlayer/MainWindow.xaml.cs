using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
