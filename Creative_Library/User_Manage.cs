using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Creative_Library
{
    public partial class User_Manage : Form
    {
        public User_Manage()
        {
            InitializeComponent();
        }

        string connectionstring = "Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;";

        string SqlQuery = "SELECT * FROM 회원";

        private void LoadDataIntoDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(SqlQuery, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                dataGridView1.DataSource = datatable;
            }
        }

        private void User_Manage_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void AMD_Click(object sender, EventArgs e) // 관리자 메인 화면으로 이동 (도서 관리 화면)
        {
            Admin_Main_Display AMD = new Admin_Main_Display();
            AMD.Show();
            this.Hide();
        }

        private void UM_Click(object sender, EventArgs e) // 회원 관리 버튼
        {
            // 본인 폼을 가리키는 역할이라 비활성화
        }

        private void SEARCH_Click(object sender, EventArgs e) // 회원 검색 버튼
        {
            try
            {
                string username = USERNAME_UM.Text.Trim();
                string userid = USERID_UM.Text.Trim();
                string userphone = USERPHONE_UM.Text.Trim();

                string SearchQuery = "SELECT * FROM 회원 WHERE 1=1";

                if (!string.IsNullOrEmpty(username))
                {
                    SearchQuery += $" AND 회원.이름 LIKE '%{username}%'";
                }

                if (!string.IsNullOrEmpty(userid))
                {
                    SearchQuery += $" AND 회원.아이디 LIKE '%{userid}%'";
                }

                if (!string.IsNullOrEmpty(userphone))
                {
                    SearchQuery += $" AND 회원.전화번호 LIKE '%{userphone}%'";
                }

                SqlQuery = SearchQuery;

                // 데이터그리드뷰 업데이트
                LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색중 오류가 발생했습니다." + ex.Message);
            }
        }

        private void USER_DELETE_Click(object sender, EventArgs e) // 회원 삭제 버튼
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // 1. 선택한 행의 인덱스 가져오기
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];

                    // 2. 데이터 가져오기
                    string userID = rowIndex.Cells["아이디"].Value.ToString();

                    // 3. 삭제 버튼 이벤트 처리
                    // 선택한 행의 데이터를 데이터베이스에서 삭제
                    string query = "DELETE FROM 회원 WHERE 아이디 = @아이디";

                    using (MySqlConnection connection = new MySqlConnection(connectionstring))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@아이디", userID);

                        command.ExecuteNonQuery();
                    }

                    // 4. 데이터그리드뷰 업데이트
                    // 데이터를 다시 가져와서 데이터그리드뷰에 반영
                    LoadDataIntoDataGridView();
                }
                else
                {
                    MessageBox.Show("삭제할 행을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PW_RESET_Click(object sender, EventArgs e) // 비밀번호 재설정 버튼
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // 1. 선택한 행의 인덱스 가져오기
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];

                    // 2. 데이터 가져오기
                    // 바뀌어야할 정보1
                    string userID = rowIndex.Cells["아이디"].Value.ToString();

                    // 바꿀 정보 4
                    string password = PASSWORD.Text;

                    // 3. 수정 버튼 이벤트 처리
                    // 가져온 값을 사용하여 데이터 수정 작업 수행 

                    // 4. 예외 처리
                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("바꿀 비밀번호를 입력하지 않았습니다.");
                        return;
                    }

                    // 5. 데이터 수정
                    // 예시: 데이터베이스에서 해당 열 값을 수정
                    string query = "UPDATE 회원 SET 비밀번호 = @password WHERE 아이디 = @userid";

                    using (MySqlConnection connection = new MySqlConnection(connectionstring))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@userid", userID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("선택한 회원의 비밀번호가 변경되었습니다.");
                    }

                    // 6. 데이터그리드뷰 업데이트
                    // 데이터를 다시 가져와서 데이터그리드뷰에 반영
                    LoadDataIntoDataGridView();
                }
                else
                {
                    MessageBox.Show("비밀번호를 바꿀 회원을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ALBA_CONTROL_Click(object sender, EventArgs e) // 알바 권한 부여
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // 1. 선택한 행의 인덱스 가져오기
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];

                    // 2. 데이터 가져오기
                    // 바뀌어야할 정보
                    string userID = rowIndex.Cells["아이디"].Value.ToString();

                    // 바꿀 정보
                    string alba = "alba";
                    string user = "user";
                    string role = rowIndex.Cells["역할"].Value.ToString();

                    // 3. 수정 버튼 이벤트 처리
                    // 가져온 값을 사용하여 데이터 수정 작업 수행 



                    // 4. 데이터 수정
                    // 예시: 데이터베이스에서 해당 열 값을 수정
                    if (role == "alba")
                    {
                        string query = "UPDATE 회원 SET 역할 = @user WHERE 아이디 = @userid";

                        using (MySqlConnection connection = new MySqlConnection(connectionstring))
                        {
                            connection.Open();

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@user", user);
                            command.Parameters.AddWithValue("@userid", userID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("권한이 회원으로 변경되었습니다.");
                        }
                    }
                    else if (role == "user")
                    {
                        string query = "UPDATE 회원 SET 역할 = @alba WHERE 아이디 = @userid";

                        using (MySqlConnection connection = new MySqlConnection(connectionstring))
                        {
                            connection.Open();

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@alba", alba);
                            command.Parameters.AddWithValue("@userid", userID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("권한이 알바로 변경되었습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("관리자의 권한은 수정할 수 없습니다.");
                    }

                    // 6. 데이터그리드뷰 업데이트
                    // 데이터를 다시 가져와서 데이터그리드뷰에 반영
                    LoadDataIntoDataGridView();
                }
                else
                {
                    MessageBox.Show("역할을 바꿀 회원을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void USERNAME_UM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_Click(sender, e);
            }
        }

        private void USERID_UM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_Click(sender, e);
            }
        }

        private void USERPHONE_UM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_Click(sender, e);
            }
        }
    }
}
