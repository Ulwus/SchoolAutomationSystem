﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MySql.Data.MySqlClient;
using OkulOtomasyon.Models;

namespace OkulOtomasyon
{
    public partial class Panel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Account account;
        public Panel(Account account)
        {
            this.account = account;
            InitializeComponent();
            this.FormClosing += Panel_FormClosing;
        }
        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            NotIslemi notIslemi = new NotIslemi(account);
            notIslemi.MdiParent = this;
            notIslemi.Show();

        }

        private void Panel_Load(object sender, EventArgs e)
        {
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            ribbonPage4.Visible = false;

            int userPermission = account.UserPermission;
            switch (userPermission)
            {
                case 0:
                    ribbonPage4.Visible = true;
                    
                    HosGeldinOgrenci hosGeldinOgrenci = new HosGeldinOgrenci(account);
                    hosGeldinOgrenci.MdiParent = this;
                    hosGeldinOgrenci.Show();
                    break;
                case 1:
                    ribbonPage2.Visible = true;
                    HosGeldinOgretmen hosGeldinOgretmen = new HosGeldinOgretmen(account);
                    hosGeldinOgretmen.MdiParent = this;
                    hosGeldinOgretmen.Show();

                    break;
                case 2:
                    ribbonPage3.Visible = true;
                    HosGeldinAdmin hosGeldinAdmin = new HosGeldinAdmin(2);
                    hosGeldinAdmin.MdiParent = this;
                    hosGeldinAdmin.Show();
                    break;
            }


        }



        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciIslemi ogrenciEkle = new OgrenciIslemi();
            ogrenciEkle.MdiParent = this;
            ogrenciEkle.Show();
        }

      

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            SinifIslemi sinifIslemi = new SinifIslemi();
            sinifIslemi.MdiParent = this;
            sinifIslemi.Show();
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            DersProgramiOlustur dersProgramiOlustur = new DersProgramiOlustur();
            dersProgramiOlustur.MdiParent = this;
            dersProgramiOlustur.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgretmenIslemi ogretmenIslemi = new OgretmenIslemi();
            ogretmenIslemi.MdiParent = this;
            ogretmenIslemi.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            DersIslemi dersIslemi = new DersIslemi();
            dersIslemi.MdiParent = this;
            dersIslemi.Show();
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            EtkinlikIslemi etkinlikIslemi = new EtkinlikIslemi();
            etkinlikIslemi.MdiParent = this;
            etkinlikIslemi.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            DersProgramiGoruntuleOgrenci dersProgramiGoruntule = new DersProgramiGoruntuleOgrenci(account);
            dersProgramiGoruntule.MdiParent = this;
            dersProgramiGoruntule.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            DersProgramiGoruntuleOgretmen dersProgramiGoruntuleOgretmen = new DersProgramiGoruntuleOgretmen(account);
            dersProgramiGoruntuleOgretmen.MdiParent = this;
            dersProgramiGoruntuleOgretmen.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            EtkinlikGoruntule etkinlikGoruntule = new EtkinlikGoruntule();
            etkinlikGoruntule.MdiParent = this;
            etkinlikGoruntule.Show();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevamsizlikGoruntulemeOgrenci devamsizlikGoruntulemeOgrenci = new DevamsizlikGoruntulemeOgrenci(account);
            devamsizlikGoruntulemeOgrenci.MdiParent = this;
            devamsizlikGoruntulemeOgrenci.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            EtkinlikGoruntule etkinlikGoruntule = new EtkinlikGoruntule();
            etkinlikGoruntule.MdiParent = this;
            etkinlikGoruntule.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            NotGoruntulemeOgrenci notGoruntulemeOgrenci = new NotGoruntulemeOgrenci(account);
            notGoruntulemeOgrenci.MdiParent = this;
            notGoruntulemeOgrenci.Show();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            int userPermission = account.UserPermission;
            switch (userPermission)
            {
                case 0:
                    ribbonPage4.Visible = true;
                    HosGeldinOgrenci hosGeldinOgrenci = new HosGeldinOgrenci(account);
                    hosGeldinOgrenci.MdiParent = this;
                    hosGeldinOgrenci.Show();
                    break;
                case 1:
                    ribbonPage2.Visible = true;
                    HosGeldinOgretmen hosGeldinOgretmen = new HosGeldinOgretmen(account);
                    hosGeldinOgretmen.MdiParent = this;
                    hosGeldinOgretmen.Show();

                    break;
                case 2:
                    ribbonPage3.Visible = true;
                    HosGeldinAdmin hosGeldinAdmin = new HosGeldinAdmin(2);
                    hosGeldinAdmin.MdiParent = this;
                    hosGeldinAdmin.Show();
                    break;
            }
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevamsizlikIslemi devamsizlikIslemi = new DevamsizlikIslemi(account);
            devamsizlikIslemi.MdiParent = this;
            devamsizlikIslemi.Show();
        }
    }
}