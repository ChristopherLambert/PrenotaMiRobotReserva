using PrenotiRobot.Services;

namespace PrenotiRobot
{
    public partial class Form1 : Form
    {
        private RobotClass robot;
        public Form1()
        {
            InitializeComponent();
            this.robot = new RobotClass();
            this.BtnMain.Enabled = true;
            this.CheckLogin.Enabled = false;

            //var trobot = new Task(() =>
            //{
            //    robot.StartRobot();
            //});

            //trobot.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var trobot = new Task(() =>
            {
                this.robot.StartRobot();
                this.robot.StateRunningChanged += Robot_StateRunningChanged;
            });

            trobot.Start();
        }

        private void CheckLogin_Click(object sender, EventArgs e)
        {
            robot.LoginPrenoti();
        }

        private void Robot_StateRunningChanged(object sender, EventArgs e)
        {
            this.BtnMain.Enabled = !this.robot.isRunning;
            this.CheckLogin.Enabled = this.robot.isRunning;
        }
    }
}