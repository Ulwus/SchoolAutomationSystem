using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public partial class DersProgramiOlustur : Form
{
    private MySqlConnection connection;
    private DataTable dersProgrami;

    public DersProgramiOlustur()
    {
        InitializeComponent();
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        dersProgrami = new DataTable();
        KontrolleriDoldur();
        DersProgramiTablosuOlustur();

        this.btnEkle.Click += new EventHandler(btnEkle_Click);
        this.btnKaydet.Click += new EventHandler(btnKaydet_Click);
    }

    private void KontrolleriDoldur()
    {
        try
        {
            connection.Open();

            // Sınıfları Doldur
            string sinifQuery = "SELECT sinifID, sinifName FROM sinif";
            MySqlDataAdapter daSinif = new MySqlDataAdapter(sinifQuery, connection);
            DataTable dtSinif = new DataTable();
            daSinif.Fill(dtSinif);
            cmbSinif.DataSource = dtSinif;
            cmbSinif.DisplayMember = "sinifName";
            cmbSinif.ValueMember = "sinifID";

            // Dersleri Doldur
            string dersQuery = "SELECT dersID, dersIsmi FROM ders";
            MySqlDataAdapter daDers = new MySqlDataAdapter(dersQuery, connection);
            DataTable dtDers = new DataTable();
            daDers.Fill(dtDers);
            cmbDers.DataSource = dtDers;
            cmbDers.DisplayMember = "dersIsmi";
            cmbDers.ValueMember = "dersID";

            // Öğretmenleri Doldur
            string ogretmenQuery = "SELECT ogretmenID, CONCAT(ogretmenIsim, ' ', ogretmenSoyisim) as AdSoyad FROM ogretmen";
            MySqlDataAdapter daOgretmen = new MySqlDataAdapter(ogretmenQuery, connection);
            DataTable dtOgretmen = new DataTable();
            daOgretmen.Fill(dtOgretmen);
            cmbOgretmen.DataSource = dtOgretmen;
            cmbOgretmen.DisplayMember = "AdSoyad";
            cmbOgretmen.ValueMember = "ogretmenID";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    private void DersProgramiTablosuOlustur()
    {
        dersProgrami.Columns.Add("Gün");
        dersProgrami.Columns.Add("Başlangıç");
        dersProgrami.Columns.Add("Bitiş");
        dersProgrami.Columns.Add("Ders");
        dersProgrami.Columns.Add("Öğretmen");
        dersProgrami.Columns.Add("Sınıf");
        dgvDersProgrami.DataSource = dersProgrami;
    }

    private bool CakismaKontrol(string gun, DateTime baslangic, DateTime bitis)
    {
        foreach (DataRow row in dersProgrami.Rows)
        {
            if (row["Gün"].ToString() == gun)
            {
                DateTime mevcut_baslangic = DateTime.Parse(row["Başlangıç"].ToString());
                DateTime mevcut_bitis = DateTime.Parse(row["Bitiş"].ToString());

                if ((baslangic >= mevcut_baslangic && baslangic < mevcut_bitis) ||
                    (bitis > mevcut_baslangic && bitis <= mevcut_bitis))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (CakismaKontrol(cmbGun.Text, dtpBaslangic.Value, dtpBitis.Value))
        {
            MessageBox.Show("Bu saatlerde çakışma var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        dersProgrami.Rows.Add(
            cmbGun.Text,
            dtpBaslangic.Value.ToShortTimeString(),
            dtpBitis.Value.ToShortTimeString(),
            cmbDers.Text,
            cmbOgretmen.Text,
            cmbSinif.Text
        );
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            connection.Open();
            foreach (DataRow row in dersProgrami.Rows)
            {
                string query = @"INSERT INTO ders_programi 
                               (sinifID, dersID, ogretmenID, gun, baslangicSaati, bitisSaati) 
                               VALUES 
                               (@sinifID, @dersID, @ogretmenID, @gun, @baslangic, @bitis)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@sinifID", cmbSinif.SelectedValue);
                cmd.Parameters.AddWithValue("@dersID", cmbDers.SelectedValue);
                cmd.Parameters.AddWithValue("@ogretmenID", cmbOgretmen.SelectedValue);
                cmd.Parameters.AddWithValue("@gun", row["Gün"]);
                cmd.Parameters.AddWithValue("@baslangic", DateTime.Parse(row["Başlangıç"].ToString()));
                cmd.Parameters.AddWithValue("@bitis", DateTime.Parse(row["Bitiş"].ToString()));

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Ders programı başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    private void DersProgramiOlustur_Load(object sender, EventArgs e)
    {
        Listele();
    }

    private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    public void Listele()
    {
        string komut = "SELECT * FROM ders_programi";
        MySqlDataAdapter da = new MySqlDataAdapter(komut, connection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gridControl1.DataSource = ds.Tables[0];
    }

    private void button1_Click(object sender, EventArgs e)
    {
        OtomatikDersProgramiOlustur();
    }

    // ...existing code...
    public void OtomatikDersProgramiOlustur()
    {
        string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
        string[] saatler = { "09:00-09:45", "10:00-10:45", "11:00-11:45", "13:00-13:45", "14:00-14:45", "15:00-15:45" };

        try
        {
            connection.Open();

            // Önce mevcut ders programını temizle
            MySqlCommand clearCmd = new MySqlCommand("DELETE FROM ders_programi", connection);
            clearCmd.ExecuteNonQuery();

            // Tüm dersleri ve saat sayılarını çek
            MySqlCommand dersCmd = new MySqlCommand("SELECT dersID, dersIsmi, dersSaat FROM ders ORDER BY dersSaat DESC", connection);
            MySqlDataAdapter dersDa = new MySqlDataAdapter(dersCmd);
            DataTable dtDersler = new DataTable();
            dersDa.Fill(dtDersler);

            // Öğretmenleri çek
            MySqlCommand ogretmenCmd = new MySqlCommand(
                "SELECT o.ogretmenID, o.ogretmenIsim, o.ogretmenSoyisim, o.ogretmenBrans " +
                "FROM ogretmen o ORDER BY o.ogretmenID", connection);
            MySqlDataAdapter ogretmenDa = new MySqlDataAdapter(ogretmenCmd);
            DataTable dtOgretmenler = new DataTable();
            ogretmenDa.Fill(dtOgretmenler);

            // Sınıfları çek
            MySqlCommand sinifCmd = new MySqlCommand("SELECT sinifID FROM sinif", connection);
            MySqlDataAdapter sinifDa = new MySqlDataAdapter(sinifCmd);
            DataTable dtSiniflar = new DataTable();
            sinifDa.Fill(dtSiniflar);

            // Her sınıf için ders programı oluştur
            foreach (DataRow sinifRow in dtSiniflar.Rows)
            {
                var sinifID = sinifRow["sinifID"];
                Dictionary<int, int> dersKalanSaat = new Dictionary<int, int>();

                // Derslerin haftalık saat sayılarını başlangıç değerlerine ayarla
                foreach (DataRow dersRow in dtDersler.Rows)
                {
                    dersKalanSaat[Convert.ToInt32(dersRow["dersID"])] = Convert.ToInt32(dersRow["dersSaat"]);
                }

                // Her gün için
                foreach (string gun in gunler)
                {
                    // Her saat dilimi için
                    foreach (string saatAraligi in saatler)
                    {
                        var times = saatAraligi.Split('-');
                        DateTime baslangic = DateTime.Parse(times[0]);
                        DateTime bitis = DateTime.Parse(times[1]);

                        // Kalan saati olan dersleri öncelik sırasına göre bul
                        var atanabilecekDersler = dtDersler.AsEnumerable()
                            .Where(d => dersKalanSaat[Convert.ToInt32(d["dersID"])] > 0)
                            .OrderByDescending(d => dersKalanSaat[Convert.ToInt32(d["dersID"])])
                            .ToList();

                        if (!atanabilecekDersler.Any())
                        {
                            // Tüm derslerin saatlerini yeniden ayarla
                            foreach (DataRow dersRow in dtDersler.Rows)
                            {
                                dersKalanSaat[Convert.ToInt32(dersRow["dersID"])] = Convert.ToInt32(dersRow["dersSaat"]);
                            }
                            atanabilecekDersler = dtDersler.AsEnumerable()
                                .OrderByDescending(d => dersKalanSaat[Convert.ToInt32(d["dersID"])])
                                .ToList();
                        }

                        bool dersAtandi = false;
                        foreach (var ders in atanabilecekDersler)
                        {
                            int dersID = Convert.ToInt32(ders["dersID"]);
                            string dersIsmi = ders["dersIsmi"].ToString();

                            // Bu ders için tüm uygun öğretmenleri bul
                            var uygunOgretmenler = BulTumMusaitOgretmenler(gun, baslangic, bitis, dersIsmi);

                            if (uygunOgretmenler.Any())
                            {
                                // En az dersi olan öğretmeni seç
                                var secilenOgretmen = uygunOgretmenler
                                    .OrderBy(o => GetOgretmenDersSayisi(Convert.ToInt32(o["ogretmenID"]), gun))
                                    .First();

                                // Ders programına ekle
                                string insertQuery = @"INSERT INTO ders_programi 
                                (sinifID, dersID, ogretmenID, gun, baslangicSaati, bitisSaati) 
                                VALUES (@sinifID, @dersID, @ogretmenID, @gun, @baslangic, @bitis)";

                                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                                insertCmd.Parameters.AddWithValue("@sinifID", sinifID);
                                insertCmd.Parameters.AddWithValue("@dersID", dersID);
                                insertCmd.Parameters.AddWithValue("@ogretmenID", secilenOgretmen["ogretmenID"]);
                                insertCmd.Parameters.AddWithValue("@gun", gun);
                                insertCmd.Parameters.AddWithValue("@baslangic", baslangic);
                                insertCmd.Parameters.AddWithValue("@bitis", bitis);
                                insertCmd.ExecuteNonQuery();

                                dersKalanSaat[dersID]--;
                                dersAtandi = true;
                                break;
                            }
                        }

                        if (!dersAtandi)
                        {
                            throw new Exception($"Ders ataması yapılamadı: {gun} {saatAraligi} için hiçbir uygun kombinasyon bulunamadı.");
                        }
                    }
                }
            }
            MessageBox.Show("Ders programı başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    private List<DataRow> BulTumMusaitOgretmenler(string gun, DateTime baslangic, DateTime bitis, string dersIsmi)
    {
        string query = @"SELECT DISTINCT o.* 
                    FROM ogretmen o 
                    WHERE o.ogretmenBrans = @dersIsmi
                    AND o.ogretmenID NOT IN (
                        SELECT dp.ogretmenID 
                        FROM ders_programi dp 
                        WHERE dp.gun = @gun 
                        AND (
                            (dp.baslangicSaati <= @bitis AND dp.bitisSaati >= @baslangic)
                            OR
                            (dp.baslangicSaati >= @baslangic AND dp.baslangicSaati < @bitis)
                            OR
                            (dp.bitisSaati > @baslangic AND dp.bitisSaati <= @bitis)
                        )
                    )";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@dersIsmi", dersIsmi);
        cmd.Parameters.AddWithValue("@gun", gun);
        cmd.Parameters.AddWithValue("@baslangic", baslangic);
        cmd.Parameters.AddWithValue("@bitis", bitis);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt.AsEnumerable().ToList();
    }

    private int GetOgretmenDersSayisi(int ogretmenID, string gun)
    {
        string query = @"SELECT COUNT(*) 
                    FROM ders_programi 
                    WHERE ogretmenID = @ogretmenID 
                    AND gun = @gun";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);
        cmd.Parameters.AddWithValue("@gun", gun);

        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    private void btnEkle_Click_1(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        DersProgramiGoruntule dersProgramiGoruntule = new DersProgramiGoruntule();
        dersProgramiGoruntule.Show();
    }
}