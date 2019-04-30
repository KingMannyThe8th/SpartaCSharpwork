using System;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace TIC_TAC_TOE_GAME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Private Members
        /// <summary>
        /// results holds the current results of cells in the active game
        /// </summary>
        private mark_type[] mResults;

        private bool mplayer1_turn;
        /// <summary>
        /// true, if it is player 1s turn (X) or player 2's turn (O)
        /// </summary>

        private bool mGameEnded;
        private Brush brushes;

         

        /// <summary>
        /// true, if the game has ended 
        /// </summary>
        #endregion

        #region //CONSTRUCTOR REGION - START
        public MainWindow() //CONSTRUCTOR
        {
            InitializeComponent();

            NewGame();

        }
        #endregion //CONSTRUCTOR REGION - END

        /// <summary>
        /// STARTS A NEW GAME AND CLEARS ALL VALUES BACK TO THE START 
        /// </summary>
        private void NewGame()
        {
            mResults = new mark_type[9];//create a new blank array of cells

            for (var i = 0; i < mResults.Length; i++)
            {
                mResults[i] = mark_type.Free;

                //Make sure Player 1 starts the game
                mplayer1_turn = true; 
              }
            
            //iterate every button on the grid
            Container.Children.Cast<Button>().ToList().ForEach(Button => {
                Button.Content = string.Empty; //empties button content of any string, i.e "X" or "O"

                //CHANGE BACKGROUND, FOREGROUND AND CONTENT OF TIC-TAC-TOE GRID TO DEFAULT VALUES
                Button.Background = Brushes.White;
                Button.Foreground = Brushes.Blue; 

                }); //Converts array of children 

            //ToList fetches every button 
            //the grid area - we need to clear it for a new game 

            //make sure the game hasn't finished
            mGameEnded = false;

                //Sets the BACKGROUND COLOUR OF SCREEN TO SKY BLUE
                BiggerContainer.Background = Brushes.SkyBlue;

            //if ((mResults[] && mResults[] && mResults[] == mResults[]) = false) { NewGame(); }
            //; 


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mGameEnded)
            {
                NewGame();

                return; 
            }

            var button = (Button)sender;

            var column = Grid.GetColumn(button); //UI ELEMENT - This returns the COLUMN that the button is on

            var row = Grid.GetRow(button); //THIS RETURNS THE ROW THAT THE BUTTON IS ON

            var index = column + (row * 3); //eg. Row 0 Column 0 has an index of 0, 1 would 1,0 would have an index of 1

            //dont do anything if the cell already has a value in it
                if (mResults[index] != mark_type.Free)
                return;

            //get cell value based on who's turn it is
            if (mplayer1_turn)

                mResults[index] = mark_type.Cross;
            else
                mResults[index] = mark_type.Nought;

            //set button text to result

            button.Content = mplayer1_turn ? "X" : "O";
             button.IsEnabled = true; 

            //if (mplayer1_turn)
            // mplayer1_turn = false;
            //else
            // mplayer1_turn = true; 

            //If true, its false .....if false, it's true

            // Change colour of noughts to RED
            if (!mplayer1_turn)
            {
                button.Foreground = Brushes.Red;
            }

            mplayer1_turn ^= true; //TOGGLES PLAYERS /INVERTS VALUE

            //CHECK FOR DRAW

            //IF NONE OF THE SPACES ARE FREE & THERE ARE NO EQUAL VALUES "THATS A DRAW" and we refresh the game

            if (mResults[1] != mark_type.Free)
            {
                
            }

            //if()

            //CHECK FOR WINNER
            CheckForWinner();




        }
        /// <summary>
        /// check if there is a winner of a 3 line straight
        /// </summary>
        private void CheckForWinner()
        {
            #region Horizontal Wins
            //Horizontal wins - ROw 0

            /// checks if ALL 3 VALUES ARE THE SAME, BEFORE ENDING GAME FOR THE WINNER - USING "AND" LOGIC 
            if(mResults[0] != mark_type.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0]) 
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;

            }
            

            //Horizontal wins - ROw 1
            if (mResults[3] != mark_type.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;


            } 
            

            //Horizontal wins - ROw 2
            if (mResults[6] != mark_type.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;


            }
            
            #endregion

            #region Vertical Wins

            //CHECK FOR VERTICAL WINS

            //Column 0 - 1st Column 
            if (mResults[0] != mark_type.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;


            }

            // Column 1 - 2nd Column 
            if (mResults[1] != mark_type.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;


            }


            // COLUMN 2 - 3rd Column
            if (mResults[2] != mark_type.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;


            }
            #endregion



            #region Diagonal Wins 



            //Diagonal 1 - Top Left to Bottom Right 
            if (mResults[0] != mark_type.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;


            }

            // Diagonal 2 -Top Right to Bottom Left
            if (mResults[2] != mark_type.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                //We end the game
                mGameEnded = true;

                //highlight winning cells in green
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;


            }

            #endregion

            //checks for no winner/full board
            if (!mResults.Any(f => f == mark_type.Free))
            {
                //game ends

                // turn cells orange
                Container.Children.Cast<Button>().ToList().ForEach(Button => {
                    Button.Content = string.Empty; //empties button content of any string, i.e "X" or "O"

                    //CHANGE BACKGROUND, FOREGROUND AND CONTENT TO DEFAULT VALUES
                    Button.Background = Brushes.Silver;
                    

                });


            }
                  

        }

        
    }
}
