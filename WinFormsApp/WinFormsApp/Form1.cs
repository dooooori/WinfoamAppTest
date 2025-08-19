namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// クリアボタン
        /// 検索条件などのクリアを行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //検索条件のクリア
            KeyBox.Text = "";
            DecimalBox.Text = "";
            DateTimeBox.Text = "";
            comboBox1.Text = "";
            checkBox1.Checked = false;

            //画面すべてクリアの場合
            if (radioButton2.Checked)
            {
                //グリッドビューの内容クリア
            }

        }


        /// <summary>
        /// 選択フォーム(ダイアログ)へ遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        /// <summary>
        /// フォームを閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
