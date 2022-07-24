using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1 {
    public partial class Form1 : Form {
        [DllImport( "user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall )]
        public static extern void mouse_event( uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo );
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        // DLL libraries used to manage hotkeys
        [DllImport( "user32.dll" )]
        public static extern bool RegisterHotKey( IntPtr hWnd, int id, int fsModifiers, int vlc );
        [DllImport( "user32.dll" )]
        public static extern bool UnregisterHotKey( IntPtr hWnd, int id );
        const int HOTKEY_ID = 'Q';


        bool KeyPressed = false;
        private System.Threading.Thread Listener = null;

        public Form1() {
            InitializeComponent();

            ClickAmountBox.Value = 0;
            IntervalAmountBox.Value = 0;

            RegisterHotKey( this.Handle, HOTKEY_ID, 3, ( int ) Keys.Q );

            CancelledLabel.Text = "Cancelled? -> False";
        }

        private void StartButton_Click( object sender, EventArgs e ) {
            KeyPressed = false;
            CancelledLabel.Text = "Cancelled? -> False";

            System.Windows.Forms.Cursor.Position = new System.Drawing.Point( GetX(), GetY() );

            MouseClick( uint.Parse( GetX().ToString() ), uint.Parse( GetY().ToString() ) );
        } 

        private void StopButton_Click( object sender, EventArgs e ) {
            MessageBox.Show( "Test" );
        }

        private void SetMousePosBox_Click( object sender, EventArgs e ) {
            MessageBox.Show( "This is a tool to get your mouse's position by simply placing it somewhere. Move your mouse to a position and click the spacebar to record its coordinates. The boxes will autofill the values" );

            #region PopUpForm Definition

            Form PopUpForm = new Form();
            PopUpForm.Size = new System.Drawing.Size( 250, 250 );
            PopUpForm.MaximizeBox = false;
            PopUpForm.MinimizeBox = false;
            PopUpForm.StartPosition = FormStartPosition.CenterScreen;
            PopUpForm.TopMost = true;
            PopUpForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            PopUpForm.ControlBox = false;

            Label WaitingLabel = new System.Windows.Forms.Label();
            WaitingLabel.Text = "Waiting for spacebar...";
            WaitingLabel.Size = new System.Drawing.Size( 200, 15 );
            WaitingLabel.Location = new System.Drawing.Point( 15, 15 );

            Label LabelX = new System.Windows.Forms.Label();
            LabelX.Text = "Mouse X: ";
            LabelX.Location = new System.Drawing.Point( 15, 40 );
            LabelX.Size = new System.Drawing.Size( 200, 15 );

            Label LabelY = new System.Windows.Forms.Label();
            LabelY.Text = "Mouse Y: ";
            LabelY.Location = new System.Drawing.Point( 15, 60 );
            LabelY.Size = new System.Drawing.Size( 200, 15 );

            Button OKButton = new System.Windows.Forms.Button();
            OKButton.Location = new System.Drawing.Point( 15, 90 );
            OKButton.Text = "OK";
            OKButton.Click += new EventHandler( OkButtonClicked );

            PopUpForm.Controls.Add( WaitingLabel );
            PopUpForm.Controls.Add( OKButton );
            PopUpForm.Controls.Add( LabelX );
            PopUpForm.Controls.Add( LabelY );

            PopUpForm.Show();

            #endregion


            #region Listener Thread Starts

            Listener = new System.Threading.Thread( UpdateMouseLocation );
            Listener.Start();

            #endregion

            void UpdateMouseLocation() {
                while( true ) {
                    try {

                        Invoke(
                            new Action(
                                () => {
                                    LabelX.Text = "Mouse X: " + System.Windows.Forms.Cursor.Position.X.ToString();
                                    LabelY.Text = "Mouse Y: " + System.Windows.Forms.Cursor.Position.Y.ToString();
                                }
                                )
                            );
                    } catch( ObjectDisposedException ) {
                        ;
                    }
                }
            }

            void OkButtonClicked( object sender1, EventArgs e1 ) {
                PopUpForm.Close();
                Invoke( new Action( () => {
                    Listener.Abort();
                } ) );
                BoxMouseX.Value = Int32.Parse( System.Windows.Forms.Cursor.Position.X.ToString() );
                BoxMouseY.Value = Int32.Parse( System.Windows.Forms.Cursor.Position.Y.ToString() );
            }
        }

        private new async void MouseClick( uint X, uint Y ) {
            foreach( var i in Enumerable.Range( 0, GetClickAmount() ) ) {
                if( !KeyPressed ) {
                    mouse_event( MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0 );
                    await Task.Delay( GetIntervalAmount() );
                }
                
            }
        }

        #region Functions that return values

        int MouseX() {
            return Int32.Parse( BoxMouseX.Value.ToString() );
        }

        int MouseY() {
            return Int32.Parse( BoxMouseY.Value.ToString() );
        }

        int GetClickAmount() {
            return Int32.Parse( ClickAmountBox.Value.ToString() );
        }

        int GetIntervalAmount() {
            return Int32.Parse( IntervalAmountBox.Value.ToString() );
        }

        int GetX() {
            return Int32.Parse( BoxMouseX.Value.ToString() );
        }

        int GetY() {
            return Int32.Parse( BoxMouseY.Value.ToString() );
        }

        #endregion

        protected override void WndProc( ref Message m ) {
            if( m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_ID ) {
                KeyPressed = true;
                CancelledLabel.Text = "Cancelled? -> True";
            }
            base.WndProc( ref m );
        }

        private void CancelledLabel_Click( object sender, EventArgs e ) {

        }

        private void label1_Click( object sender, EventArgs e ) {

        }
    }
}