using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeresiyeTakip
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni kayıt giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()       //ctor tab tab
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir \n Güncelleme işlemini onaylıyor musunuz?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrar kaydetmek istiyor musunuz?", "Kayıt uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Cari kayıt silinecektir.\n Silme işlemini onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Sil(string x)
        {
            return MessageBox.Show(x, "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult Yazdir()
        {
            return MessageBox.Show("Kaydı yazdırmak istiyor musunuz?", "Yazdırma işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult BosAlanHatasi()
        {
            return MessageBox.Show("Adı soyadı alanı boş geçilemez", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
