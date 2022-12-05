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
        public Random rnd = new Random();
        public Dictionary<int, int> explist = new Dictionary<int, int>()
        {
            {1, 100},
            {2, 300},
            {3, 800},
            {4, 1800},
            {5, 3000}
        };
        public Dictionary<int, int> Pointlist = new Dictionary<int, int>()
        {
            {2, 2},
            {3, 3},
            {4, 2},
            {5, 5}
        };
        public int MaxHP;
        public int MaxHPSecondPlayer;
        public int CurrentExp;
        public int CurrentExpSecondPlayer;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void StrengthMinus_Click(object sender, RoutedEventArgs e)
        {
            if(Strength.Text == "1")
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
            if (Dexterity.Text == "1")
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
            if (Luck.Text == "1")
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
            if (Constitution.Text == "1")
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
            if (Intteligence.Text == "1")
            {
                return;
            }
            else
            {
                FreePoints.Text = $"{int.Parse(FreePoints.Text) + 1}";
                Intteligence.Text = $"{int.Parse(Intteligence.Text) - 1}";
                manaValue.Text = $"{int.Parse(manaValue.Text) - 7}";
                mAttackValue.Text = $"{int.Parse(mAttackValue.Text) - 2}";
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
                mAttackValue.Text = $"{int.Parse(mAttackValue.Text) + 2}";
            }
        }

        private void StrengthMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (StrengthSecondPlayer.Text == "1")
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
            if (DexteritySecondPlayer.Text == "1")
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
            if (LuckSecondPlayer.Text == "1")
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
            if (ConstitutionSecondPlayer.Text == "1")
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
            if (IntteligenceSecondPlayer.Text == "1")
            {
                return;
            }
            else
            {
                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + 1}";
                IntteligenceSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) - 1}";
                manaValueSecondPlayer.Text = $"{int.Parse(manaValueSecondPlayer.Text) - 7}";
                mAttackValueSecondPlayer.Text = $"{int.Parse(mAttackValueSecondPlayer.Text) - 2}";
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
                mAttackValueSecondPlayer.Text = $"{int.Parse(mAttackValueSecondPlayer.Text) + 2}";
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
                crtValueSecondPlayer.Text = $"{(int.Parse(LuckSecondPlayer.Text) - (int.Parse(Luck.Text) * 0.5)) * 0.1}";
                if (Convert.ToDouble(crtValueSecondPlayer.Text) < 0)
                {
                    crtValueSecondPlayer.Text = "0";
                }
                evasionValueSecondPlayer.Text = $"{(int.Parse(DexteritySecondPlayer.Text) - int.Parse(Dexterity.Text)) * 0.1}";
                if (Convert.ToDouble(evasionValueSecondPlayer.Text) < 0)
                {
                    evasionValueSecondPlayer.Text = "0";
                }
                breakoutsValueSecondPlayer.Text = $"{(int.Parse(StrengthSecondPlayer.Text) - int.Parse(Strength.Text)) * 0.05}";
                if (Convert.ToDouble(breakoutsValueSecondPlayer.Text) < 0)
                {
                    breakoutsValueSecondPlayer.Text = "0";
                }               
                Ready2.Content = "Unready";
                ReadySecond = true;
                FighterModel Player2 = new FighterModel(Name.Text, int.Parse(lvlValue.Text), int.Parse(Strength.Text), int.Parse(Dexterity.Text), int.Parse(Luck.Text), int.Parse(Constitution.Text), int.Parse(Intteligence.Text));
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
                crtValue.Text = $"{(int.Parse(Luck.Text) - (int.Parse(LuckSecondPlayer.Text) * 0.5)) * 0.1}";
                if(Convert.ToDouble(crtValue.Text) < 0)
                {
                    crtValue.Text = "0";
                }
                evasionValue.Text = $"{(int.Parse(Dexterity.Text) - int.Parse(DexteritySecondPlayer.Text)) * 0.1}";
                if(Convert.ToDouble(evasionValue.Text) < 0)
                {
                    evasionValue.Text = "0";
                }
                breakoutsValue.Text = $"{(int.Parse(Strength.Text) - int.Parse(StrengthSecondPlayer.Text)) * 0.05}";
                if(Convert.ToDouble(breakoutsValue.Text) < 0)
                {
                    breakoutsValue.Text = "0";
                }
                Exp.Text = $"EXP: 0/{explist[int.Parse(lvlValue.Text)]}";
                Ready1.Content = "Unready";
                ReadyFirst = true;
                FighterModel Player1 = new FighterModel(Name.Text, int.Parse(lvlValue.Text), int.Parse(Strength.Text), int.Parse(Dexterity.Text), int.Parse(Luck.Text), int.Parse(Constitution.Text), int.Parse(Intteligence.Text));
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

        private void FightB_Click(object sender, RoutedEventArgs e)
        {
            DexterityTB.Visibility = Visibility.Hidden;
            LuckTB.Visibility = Visibility.Hidden;
            ConstitutionTB.Visibility = Visibility.Hidden;
            IntteligenceTB.Visibility = Visibility.Hidden;
            Dexterity.Visibility = Visibility.Hidden;
            FreePoints.Visibility = Visibility.Hidden;
            FreePointsTB.Visibility = Visibility.Hidden;
            Strength.Visibility = Visibility.Hidden;
            StrengthTB.Visibility = Visibility.Hidden;
            Luck.Visibility = Visibility.Hidden;
            Constitution.Visibility = Visibility.Hidden;
            Intteligence.Visibility = Visibility.Hidden;
            StrengthMinus.Visibility = Visibility.Hidden;
            DexterityMinus.Visibility = Visibility.Hidden;
            LuckMinus.Visibility = Visibility.Hidden;
            ConstitutionMinus.Visibility = Visibility.Hidden;
            IntelligenceMinus.Visibility = Visibility.Hidden;
            StrengthPlus.Visibility = Visibility.Hidden;
            DexterityPlus.Visibility = Visibility.Hidden;
            LuckPlus.Visibility = Visibility.Hidden;
            ConstitutionPlus.Visibility = Visibility.Hidden;
            IntelligencePlus.Visibility = Visibility.Hidden;
            TargetAttack.Visibility= Visibility.Visible;
            TargetDefence.Visibility = Visibility.Visible;
            AttackOrDefend.Visibility = Visibility.Visible;
            ChooseAttackTB.Visibility = Visibility.Visible;
            ChooseDefenceTB.Visibility = Visibility.Visible;
            Ready1.Visibility = Visibility.Hidden;

            DexterityTBSecondPlayer.Visibility = Visibility.Hidden;
            LuckTBSecondPlayer.Visibility = Visibility.Hidden;
            ConstitutionTBSecondPlayer.Visibility = Visibility.Hidden;
            IntteligenceTBSecondPlayer.Visibility = Visibility.Hidden;
            DexteritySecondPlayer.Visibility = Visibility.Hidden;
            FreePointsSecondPlayer.Visibility = Visibility.Hidden;
            FreePointsTBSecondPlayer.Visibility = Visibility.Hidden;
            StrengthSecondPlayer.Visibility = Visibility.Hidden;
            StrengthTBSecondPlayer.Visibility = Visibility.Hidden;
            LuckSecondPlayer.Visibility = Visibility.Hidden;
            ConstitutionSecondPlayer.Visibility = Visibility.Hidden;
            IntteligenceSecondPlayer.Visibility = Visibility.Hidden;
            StrengthMinusSecondPlayer.Visibility = Visibility.Hidden;
            DexterityMinusSecondPlayer.Visibility = Visibility.Hidden;
            LuckMinusSecondPlayer.Visibility = Visibility.Hidden;
            ConstitutionMinusSecondPlayer.Visibility = Visibility.Hidden;
            IntelligenceMinusSecondPlayer.Visibility = Visibility.Hidden;
            StrengthPlusSecondPlayer.Visibility = Visibility.Hidden;
            DexterityPlusSecondPlayer.Visibility = Visibility.Hidden;
            LuckPlusSecondPlayer.Visibility = Visibility.Hidden;
            ConstitutionPlusSecondPlayer.Visibility = Visibility.Hidden;
            IntelligencePlusSecondPlayer.Visibility = Visibility.Hidden;
            TargetAttackSecondPlayer.Visibility = Visibility.Visible;
            TargetDefenceSecondPlayer.Visibility = Visibility.Visible;
            ChooseAttackTBSecondPlayer.Visibility = Visibility.Visible;
            ChooseDefenceTBSecondPlayer.Visibility = Visibility.Visible;
            FightB.Visibility= Visibility.Hidden;
            Ready2.Visibility = Visibility.Hidden;
            mAttackB.Visibility = Visibility.Visible;
            MaxHP = int.Parse(hpValue.Text);
            MaxHPSecondPlayer = int.Parse(hpValueSecondPlayer.Text);
            Heal.Visibility= Visibility.Visible;
            HealSecondPlayer.Visibility= Visibility.Visible;
            if(int.Parse(Intteligence.Text) > 5)
            {
                Heal.IsEnabled= true;
            }
            else
            {
                Heal.IsEnabled = false;
            }

            if (int.Parse(IntteligenceSecondPlayer.Text) > 5)
            {
                HealSecondPlayer.IsEnabled = true;
            }
            else
            {
                HealSecondPlayer.IsEnabled = false;
            }
        }
        public int StepPlayers = 1;
        private void AttackOrDefend_Click(object sender, RoutedEventArgs e)
        {           
            if (StepPlayers == 1)
            {
                AttackOrDefend.Content = "Attack P2";
                
                if(TargetAttack.Text != TargetDefenceSecondPlayer.Text)
                {
                    if(rnd.Next(0, 101) < (Convert.ToDouble(evasionValueSecondPlayer.Text) * 100))
                    {
                        MessageBox.Show($"Первый игрок промахнулся");
                    }
                    else
                    {
                        if (rnd.Next(0, 101) < (Convert.ToDouble(crtValue.Text) * 100))
                        {
                            hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) - (int.Parse(pAttackValue.Text) * 2)}";
                            MessageBox.Show($"Второму игроку нанесен крит. урон в размере {int.Parse(pAttackValue.Text) * 2}");
                        }
                        else
                        {
                            hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) - int.Parse(pAttackValue.Text)}";
                            MessageBox.Show($"Второму игроку нанесен урон в размере {int.Parse(pAttackValue.Text)}");
                        }
                    }
                    if (int.Parse(hpValueSecondPlayer.Text) <= 0)
                    {                       
                        hpValueSecondPlayer.Text = "0";
                        CurrentExp += (MaxHPSecondPlayer * 3) * int.Parse(lvlValueSecondPlayer.Text);
                        CurrentExpSecondPlayer += (MaxHP - int.Parse(hpValue.Text)) * 3 * int.Parse(lvlValue.Text);
                        Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                        ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                        if (CurrentExp >= explist[int.Parse(lvlValue.Text)])
                        {
                            lvlValue.Text = $"{int.Parse(lvlValue.Text) + 1}";
                            Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                            ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                            FreePoints.Text = $"{int.Parse(FreePoints.Text) + Pointlist[int.Parse(lvlValue.Text)]}";
                        }
                        MessageBox.Show($"Первый игрок победил! {(MaxHP - int.Parse(hpValue.Text)) * 3 * int.Parse(lvlValue.Text)} {(MaxHPSecondPlayer * 3) * int.Parse(lvlValueSecondPlayer.Text)}");
                        manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                        DexterityTB.Visibility = Visibility.Visible;
                        LuckTB.Visibility = Visibility.Visible;
                        ConstitutionTB.Visibility = Visibility.Visible;
                        IntteligenceTB.Visibility = Visibility.Visible;
                        Dexterity.Visibility = Visibility.Visible;
                        FreePoints.Visibility = Visibility.Visible;
                        FreePointsTB.Visibility = Visibility.Visible;
                        Strength.Visibility = Visibility.Visible;
                        StrengthTB.Visibility = Visibility.Visible;
                        Luck.Visibility = Visibility.Visible;
                        Constitution.Visibility = Visibility.Visible;
                        Intteligence.Visibility = Visibility.Visible;                       
                        StrengthPlus.Visibility = Visibility.Visible;
                        ConstitutionPlus.Visibility = Visibility.Visible;
                        IntelligencePlus.Visibility = Visibility.Visible;
                        DexterityPlus.Visibility = Visibility.Visible;
                        LuckPlus.Visibility = Visibility.Visible;                        
                        TargetAttack.Visibility = Visibility.Hidden;
                        TargetDefence.Visibility = Visibility.Hidden;
                        AttackOrDefend.Visibility = Visibility.Hidden;
                        ChooseAttackTB.Visibility = Visibility.Hidden;
                        ChooseDefenceTB.Visibility = Visibility.Hidden;
                        mAttackB.Visibility = Visibility.Hidden;
                        Ready1.Visibility = Visibility.Visible;
                        StrengthPlus.IsEnabled = true;
                        DexterityPlus.IsEnabled = true;
                        LuckPlus.IsEnabled = true;
                        ConstitutionPlus.IsEnabled = true;
                        IntelligencePlus.IsEnabled = true;

                        DexterityTBSecondPlayer.Visibility = Visibility.Visible;
                        LuckTBSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionTBSecondPlayer.Visibility = Visibility.Visible;
                        IntteligenceTBSecondPlayer.Visibility = Visibility.Visible;
                        DexteritySecondPlayer.Visibility = Visibility.Visible;
                        FreePointsSecondPlayer.Visibility = Visibility.Visible;
                        FreePointsTBSecondPlayer.Visibility = Visibility.Visible;
                        StrengthSecondPlayer.Visibility = Visibility.Visible;
                        StrengthTBSecondPlayer.Visibility = Visibility.Visible;
                        LuckSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionSecondPlayer.Visibility = Visibility.Visible;
                        IntteligenceSecondPlayer.Visibility = Visibility.Visible;
                        StrengthPlusSecondPlayer.Visibility = Visibility.Visible;
                        DexterityPlusSecondPlayer.Visibility = Visibility.Visible;
                        LuckPlusSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionPlusSecondPlayer.Visibility = Visibility.Visible;
                        IntelligencePlusSecondPlayer.Visibility = Visibility.Visible;
                        TargetAttackSecondPlayer.Visibility = Visibility.Hidden;
                        TargetDefenceSecondPlayer.Visibility = Visibility.Hidden;
                        ChooseAttackTBSecondPlayer.Visibility = Visibility.Hidden;
                        ChooseDefenceTBSecondPlayer.Visibility = Visibility.Hidden;
                        FightB.Visibility = Visibility.Visible;
                        Ready2.Visibility = Visibility.Visible;
                        StrengthPlusSecondPlayer.IsEnabled = true;
                        DexterityPlusSecondPlayer.IsEnabled = true;
                        LuckPlusSecondPlayer.IsEnabled = true;
                        ConstitutionPlusSecondPlayer.IsEnabled = true;
                        IntelligencePlusSecondPlayer.IsEnabled = true;
                        manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                        manaValueSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) * 7}";
                        hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                        hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                    }
                }
                else
                {
                    if(rnd.Next(0, 101) < (Convert.ToDouble(breakoutsValue.Text) * 100))
                    {
                        hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) - int.Parse(pAttackValue.Text)}";
                        MessageBox.Show($"Второму игроку нанесен урон через блок в размере {int.Parse(pAttackValue.Text)}");
                    }
                    else
                    {
                        MessageBox.Show($"Второй игрок парировал удар!");
                    }                  
                }
                StepPlayers = 2;
            }
            else if (StepPlayers == 2)
            {
                AttackOrDefend.Content = "Attack P1";
                if(int.Parse(hpValue.Text) >= 0)
                {
                    if (TargetAttackSecondPlayer.Text != TargetDefence.Text)
                    {
                        if(rnd.Next(0, 101) < (Convert.ToDouble(evasionValue.Text) * 100))
                        {
                            MessageBox.Show($"Второй игрок промахнулся");
                        }
                        else
                        {                           
                            if (rnd.Next(0, 101) < (Convert.ToDouble(crtValueSecondPlayer.Text) * 100))
                            {
                                hpValue.Text = $"{int.Parse(hpValue.Text) - (int.Parse(pAttackValueSecondPlayer.Text) * 2)}";
                                MessageBox.Show($"Первому игроку нанесен крит. урон в размере {int.Parse(pAttackValueSecondPlayer.Text) * 2}");
                            }
                            else
                            {
                                hpValue.Text = $"{int.Parse(hpValue.Text) - int.Parse(pAttackValueSecondPlayer.Text)}";
                                MessageBox.Show($"Первому игроку нанесен урон в размере {int.Parse(pAttackValueSecondPlayer.Text)}");
                            }
                        }
                        if(int.Parse(hpValue.Text) < 0)
                        {
                            hpValue.Text = "0";
                            CurrentExpSecondPlayer += (MaxHP * 3) * int.Parse(lvlValue.Text);
                            CurrentExp += (MaxHPSecondPlayer - int.Parse(hpValueSecondPlayer.Text)) * 3 * int.Parse(lvlValueSecondPlayer.Text);
                            ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                            Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                            if (CurrentExpSecondPlayer >= explist[int.Parse(lvlValueSecondPlayer.Text)])
                            {
                                lvlValueSecondPlayer.Text = $"{int.Parse(lvlValueSecondPlayer.Text) + 1}";
                                ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                                Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + Pointlist[int.Parse(lvlValueSecondPlayer.Text)]}";
                            }
                            MessageBox.Show($"Второй игрок победил!");
                            hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                            hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                            DexterityTB.Visibility = Visibility.Visible;
                            LuckTB.Visibility = Visibility.Visible;
                            ConstitutionTB.Visibility = Visibility.Visible;
                            IntteligenceTB.Visibility = Visibility.Visible;
                            Dexterity.Visibility = Visibility.Visible;
                            FreePoints.Visibility = Visibility.Visible;
                            FreePointsTB.Visibility = Visibility.Visible;
                            Strength.Visibility = Visibility.Visible;
                            StrengthTB.Visibility = Visibility.Visible;
                            Luck.Visibility = Visibility.Visible;
                            Constitution.Visibility = Visibility.Visible;
                            Intteligence.Visibility = Visibility.Visible;
                            StrengthMinus.Visibility = Visibility.Visible;
                            DexterityMinus.Visibility = Visibility.Visible;
                            LuckMinus.Visibility = Visibility.Visible;
                            ConstitutionMinus.Visibility = Visibility.Visible;
                            IntelligenceMinus.Visibility = Visibility.Visible;
                            StrengthPlus.Visibility = Visibility.Visible;
                            DexterityPlus.Visibility = Visibility.Visible;
                            LuckPlus.Visibility = Visibility.Visible;
                            ConstitutionPlus.Visibility = Visibility.Visible;
                            IntelligencePlus.Visibility = Visibility.Visible;
                            TargetAttack.Visibility = Visibility.Hidden;
                            TargetDefence.Visibility = Visibility.Hidden;
                            AttackOrDefend.Visibility = Visibility.Hidden;
                            ChooseAttackTB.Visibility = Visibility.Hidden;
                            ChooseDefenceTB.Visibility = Visibility.Hidden;
                            mAttackB.Visibility = Visibility.Hidden;
                            Ready1.Visibility = Visibility.Visible;

                            DexterityTBSecondPlayer.Visibility = Visibility.Visible;
                            LuckTBSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionTBSecondPlayer.Visibility = Visibility.Visible;
                            IntteligenceTBSecondPlayer.Visibility = Visibility.Visible;
                            DexteritySecondPlayer.Visibility = Visibility.Visible;
                            FreePointsSecondPlayer.Visibility = Visibility.Visible;
                            FreePointsTBSecondPlayer.Visibility = Visibility.Visible;
                            StrengthSecondPlayer.Visibility = Visibility.Visible;
                            StrengthTBSecondPlayer.Visibility = Visibility.Visible;
                            LuckSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionSecondPlayer.Visibility = Visibility.Visible;
                            IntteligenceSecondPlayer.Visibility = Visibility.Visible;
                            StrengthMinusSecondPlayer.Visibility = Visibility.Visible;
                            DexterityMinusSecondPlayer.Visibility = Visibility.Visible;
                            LuckMinusSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionMinusSecondPlayer.Visibility = Visibility.Visible;
                            IntelligenceMinusSecondPlayer.Visibility = Visibility.Visible;
                            StrengthPlusSecondPlayer.Visibility = Visibility.Visible;
                            DexterityPlusSecondPlayer.Visibility = Visibility.Visible;
                            LuckPlusSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionPlusSecondPlayer.Visibility = Visibility.Visible;
                            IntelligencePlusSecondPlayer.Visibility = Visibility.Visible;
                            TargetAttackSecondPlayer.Visibility = Visibility.Hidden;
                            TargetDefenceSecondPlayer.Visibility = Visibility.Hidden;
                            ChooseAttackTBSecondPlayer.Visibility = Visibility.Hidden;
                            ChooseDefenceTBSecondPlayer.Visibility = Visibility.Hidden;
                            FightB.Visibility = Visibility.Visible;
                            Ready2.Visibility = Visibility.Visible;
                            hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                            hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                            manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                            manaValueSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) * 7}";
                        }
                    }
                    else
                    {
                        if (rnd.Next(0, 101) < (Convert.ToDouble(breakoutsValueSecondPlayer.Text) * 100))
                        {
                            hpValue.Text = $"{int.Parse(hpValue.Text) - int.Parse(pAttackValueSecondPlayer.Text)}";
                            MessageBox.Show($"Первому игроку нанесен урон через блок в размере {int.Parse(pAttackValueSecondPlayer.Text)}");
                        }
                        else
                        {
                            MessageBox.Show($"Первый игрок парировал удар!");
                        }                       
                    }
                }
                StepPlayers = 1;
            }
        }

        private void mAttack_Click(object sender, RoutedEventArgs e)
        {
            if (StepPlayers == 1)
            {
                mAttackB.Content = "mAttack P2";

                if (TargetAttack.Text != TargetDefenceSecondPlayer.Text)
                {
                    if(Convert.ToDouble(manaValue.Text) < 5)
                    {
                        MessageBox.Show($"Не хватает маны!");
                    }
                    else
                    {
                        hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) - int.Parse(mAttackValue.Text)}";
                        manaValue.Text = $"{int.Parse(manaValue.Text) - 5}";
                        MessageBox.Show($"Второму игроку Нанесен урон в размере {int.Parse(mAttackValue.Text)}", "Player1");
                    }
                   
                    if (int.Parse(hpValueSecondPlayer.Text) <= 0)
                    {
                        hpValueSecondPlayer.Text = "0";
                        CurrentExp += (MaxHPSecondPlayer * 3) * int.Parse(lvlValueSecondPlayer.Text);
                        CurrentExpSecondPlayer += (MaxHP - int.Parse(hpValue.Text)) * 3 * int.Parse(lvlValue.Text);
                        Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                        ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                        if (CurrentExp >= explist[int.Parse(lvlValue.Text)])
                        {
                            lvlValue.Text = $"{int.Parse(lvlValue.Text) + 1}";
                            Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                            ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                            FreePoints.Text = $"{int.Parse(FreePoints.Text) + Pointlist[int.Parse(lvlValue.Text)]}";
                        }
                        MessageBox.Show($"Первый игрок победил!");
                        hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                        manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                        hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                        manaValueSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) * 7}";
                        DexterityTB.Visibility = Visibility.Visible;
                        LuckTB.Visibility = Visibility.Visible;
                        ConstitutionTB.Visibility = Visibility.Visible;
                        IntteligenceTB.Visibility = Visibility.Visible;
                        Dexterity.Visibility = Visibility.Visible;
                        FreePoints.Visibility = Visibility.Visible;
                        FreePointsTB.Visibility = Visibility.Visible;
                        Strength.Visibility = Visibility.Visible;
                        StrengthTB.Visibility = Visibility.Visible;
                        Luck.Visibility = Visibility.Visible;
                        Constitution.Visibility = Visibility.Visible;
                        Intteligence.Visibility = Visibility.Visible;
                        StrengthMinus.Visibility = Visibility.Visible;
                        DexterityMinus.Visibility = Visibility.Visible;
                        LuckMinus.Visibility = Visibility.Visible;
                        ConstitutionMinus.Visibility = Visibility.Visible;
                        IntelligenceMinus.Visibility = Visibility.Visible;
                        StrengthPlus.Visibility = Visibility.Visible;
                        DexterityPlus.Visibility = Visibility.Visible;
                        LuckPlus.Visibility = Visibility.Visible;
                        ConstitutionPlus.Visibility = Visibility.Visible;
                        IntelligencePlus.Visibility = Visibility.Visible;
                        TargetAttack.Visibility = Visibility.Hidden;
                        TargetDefence.Visibility = Visibility.Hidden;
                        AttackOrDefend.Visibility = Visibility.Hidden;
                        ChooseAttackTB.Visibility = Visibility.Hidden;
                        ChooseDefenceTB.Visibility = Visibility.Hidden;
                        Ready1.Visibility = Visibility.Visible;
                        mAttackB.Visibility = Visibility.Hidden;

                        DexterityTBSecondPlayer.Visibility = Visibility.Visible;
                        LuckTBSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionTBSecondPlayer.Visibility = Visibility.Visible;
                        IntteligenceTBSecondPlayer.Visibility = Visibility.Visible;
                        DexteritySecondPlayer.Visibility = Visibility.Visible;
                        FreePointsSecondPlayer.Visibility = Visibility.Visible;
                        FreePointsTBSecondPlayer.Visibility = Visibility.Visible;
                        StrengthSecondPlayer.Visibility = Visibility.Visible;
                        StrengthTBSecondPlayer.Visibility = Visibility.Visible;
                        LuckSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionSecondPlayer.Visibility = Visibility.Visible;
                        IntteligenceSecondPlayer.Visibility = Visibility.Visible;
                        StrengthMinusSecondPlayer.Visibility = Visibility.Visible;
                        DexterityMinusSecondPlayer.Visibility = Visibility.Visible;
                        LuckMinusSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionMinusSecondPlayer.Visibility = Visibility.Visible;
                        IntelligenceMinusSecondPlayer.Visibility = Visibility.Visible;
                        StrengthPlusSecondPlayer.Visibility = Visibility.Visible;
                        DexterityPlusSecondPlayer.Visibility = Visibility.Visible;
                        LuckPlusSecondPlayer.Visibility = Visibility.Visible;
                        ConstitutionPlusSecondPlayer.Visibility = Visibility.Visible;
                        IntelligencePlusSecondPlayer.Visibility = Visibility.Visible;
                        TargetAttackSecondPlayer.Visibility = Visibility.Hidden;
                        TargetDefenceSecondPlayer.Visibility = Visibility.Hidden;
                        ChooseAttackTBSecondPlayer.Visibility = Visibility.Hidden;
                        ChooseDefenceTBSecondPlayer.Visibility = Visibility.Hidden;
                        FightB.Visibility = Visibility.Visible;
                        Ready2.Visibility = Visibility.Visible;
                        hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                        hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                        manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                        manaValueSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) * 7}";
                    }
                }
                else
                {
                    MessageBox.Show($"Второй игрок парировал удар!");
                }
                StepPlayers = 2;
            }
            else if (StepPlayers == 2)
            {
                mAttackB.Content = "mAttack P1";
                if (int.Parse(hpValue.Text) >= 0)
                {
                    if (TargetAttackSecondPlayer.Text != TargetDefence.Text)
                    {
                        if (Convert.ToDouble(manaValueSecondPlayer.Text) < 5)
                        {
                            MessageBox.Show($"Не хватает маны!");
                        }
                        else
                        {
                            hpValue.Text = $"{int.Parse(hpValue.Text) - int.Parse(mAttackValueSecondPlayer.Text)}";
                            manaValueSecondPlayer.Text = $"{int.Parse(manaValueSecondPlayer.Text) - 5}";
                            MessageBox.Show($"Второму игроку Нанесен урон в размере {int.Parse(mAttackValueSecondPlayer.Text)}");
                        }
                        if (int.Parse(hpValue.Text) < 0)
                        {
                            hpValue.Text = "0";
                            CurrentExpSecondPlayer += (MaxHP * 3) * int.Parse(lvlValue.Text);
                            CurrentExp += (MaxHPSecondPlayer - int.Parse(hpValueSecondPlayer.Text)) * 3 * int.Parse(lvlValueSecondPlayer.Text);
                            ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                            Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                            if (CurrentExpSecondPlayer >= explist[int.Parse(lvlValueSecondPlayer.Text)])
                            {
                                lvlValueSecondPlayer.Text = $"{int.Parse(lvlValueSecondPlayer.Text) + 1}";
                                ExpSecondPlayer.Text = $"{CurrentExpSecondPlayer}/{explist[int.Parse(lvlValueSecondPlayer.Text)]}";
                                Exp.Text = $"{CurrentExp}/{explist[int.Parse(lvlValue.Text)]}";
                                FreePointsSecondPlayer.Text = $"{int.Parse(FreePointsSecondPlayer.Text) + Pointlist[int.Parse(lvlValueSecondPlayer.Text)]}";
                            }
                            MessageBox.Show($"Второй игрок победил!");
                            hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                            manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                            hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                            manaValueSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) * 7}";
                            DexterityTB.Visibility = Visibility.Visible;
                            LuckTB.Visibility = Visibility.Visible;
                            ConstitutionTB.Visibility = Visibility.Visible;
                            IntteligenceTB.Visibility = Visibility.Visible;
                            Dexterity.Visibility = Visibility.Visible;
                            FreePoints.Visibility = Visibility.Visible;
                            FreePointsTB.Visibility = Visibility.Visible;
                            Strength.Visibility = Visibility.Visible;
                            StrengthTB.Visibility = Visibility.Visible;
                            Luck.Visibility = Visibility.Visible;
                            Constitution.Visibility = Visibility.Visible;
                            Intteligence.Visibility = Visibility.Visible;
                            StrengthMinus.Visibility = Visibility.Visible;
                            DexterityMinus.Visibility = Visibility.Visible;
                            LuckMinus.Visibility = Visibility.Visible;
                            ConstitutionMinus.Visibility = Visibility.Visible;
                            IntelligenceMinus.Visibility = Visibility.Visible;
                            StrengthPlus.Visibility = Visibility.Visible;
                            DexterityPlus.Visibility = Visibility.Visible;
                            LuckPlus.Visibility = Visibility.Visible;
                            ConstitutionPlus.Visibility = Visibility.Visible;
                            IntelligencePlus.Visibility = Visibility.Visible;
                            TargetAttack.Visibility = Visibility.Hidden;
                            TargetDefence.Visibility = Visibility.Hidden;
                            AttackOrDefend.Visibility = Visibility.Hidden;
                            ChooseAttackTB.Visibility = Visibility.Hidden;
                            ChooseDefenceTB.Visibility = Visibility.Hidden;
                            Ready1.Visibility = Visibility.Visible;

                            DexterityTBSecondPlayer.Visibility = Visibility.Visible;
                            LuckTBSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionTBSecondPlayer.Visibility = Visibility.Visible;
                            IntteligenceTBSecondPlayer.Visibility = Visibility.Visible;
                            DexteritySecondPlayer.Visibility = Visibility.Visible;
                            FreePointsSecondPlayer.Visibility = Visibility.Visible;
                            FreePointsTBSecondPlayer.Visibility = Visibility.Visible;
                            StrengthSecondPlayer.Visibility = Visibility.Visible;
                            StrengthTBSecondPlayer.Visibility = Visibility.Visible;
                            LuckSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionSecondPlayer.Visibility = Visibility.Visible;
                            IntteligenceSecondPlayer.Visibility = Visibility.Visible;
                            StrengthMinusSecondPlayer.Visibility = Visibility.Visible;
                            DexterityMinusSecondPlayer.Visibility = Visibility.Visible;
                            LuckMinusSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionMinusSecondPlayer.Visibility = Visibility.Visible;
                            IntelligenceMinusSecondPlayer.Visibility = Visibility.Visible;
                            StrengthPlusSecondPlayer.Visibility = Visibility.Visible;
                            DexterityPlusSecondPlayer.Visibility = Visibility.Visible;
                            LuckPlusSecondPlayer.Visibility = Visibility.Visible;
                            ConstitutionPlusSecondPlayer.Visibility = Visibility.Visible;
                            IntelligencePlusSecondPlayer.Visibility = Visibility.Visible;
                            TargetAttackSecondPlayer.Visibility = Visibility.Hidden;
                            TargetDefenceSecondPlayer.Visibility = Visibility.Hidden;
                            ChooseAttackTBSecondPlayer.Visibility = Visibility.Hidden;
                            ChooseDefenceTBSecondPlayer.Visibility = Visibility.Hidden;
                            FightB.Visibility = Visibility.Visible;
                            Ready2.Visibility = Visibility.Visible;
                            hpValue.Text = $"{int.Parse(Constitution.Text) * 5}";
                            hpValueSecondPlayer.Text = $"{int.Parse(ConstitutionSecondPlayer.Text) * 5}";
                            manaValue.Text = $"{int.Parse(Intteligence.Text) * 7}";
                            manaValueSecondPlayer.Text = $"{int.Parse(IntteligenceSecondPlayer.Text) * 7}";
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Первый игрок парировал удар!");
                    }
                }
                StepPlayers = 1;
            }
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(hpValue.Text) == MaxHP)
            {
                MessageBox.Show($"Лечение не требуется");
            }
            else if (int.Parse(manaValue.Text) - 2 >= 0)
            {
                while (int.Parse(hpValue.Text) != MaxHP && int.Parse(manaValue.Text) - 2 >= 0)
                {
                    manaValue.Text = $"{int.Parse(manaValue.Text) - 2}";
                    hpValue.Text = $"{int.Parse(hpValue.Text) + 1}";
                }
            }
            else
            {
                MessageBox.Show($"Не хватает маны");
            }
        }

        private void HealSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(hpValueSecondPlayer.Text) == MaxHPSecondPlayer)
            {
                MessageBox.Show($"Лечение не требуется");
            }
            else if (int.Parse(manaValueSecondPlayer.Text) - 2 >= 0)
            {
                while(int.Parse(hpValueSecondPlayer.Text) != MaxHPSecondPlayer && int.Parse(manaValueSecondPlayer.Text) - 2 >= 0)
                {
                    manaValueSecondPlayer.Text = $"{int.Parse(manaValueSecondPlayer.Text) - 2}";
                    hpValueSecondPlayer.Text = $"{int.Parse(hpValueSecondPlayer.Text) + 1}";
                }
            }            
            else
            {
                MessageBox.Show($"Не хватает маны");
            }
        }
    }
}
