using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.MediaFoundation.OPM;

namespace Teknotek_Personel_Takip_Sistemi.Class
{
    internal class KagıtTuru
    {
        static string TabloAdi = "YAZICIKAGITTUR";
        static string Kolon1 = "ID";
        static string Kolon2 = "KOD";
        static string Kolon3 = "AD";
        static string Kolon4 = "ACIKLAMA";
        static Fonksiyonlar f = new Fonksiyonlar();

        public static PaperKind TurGetir()
        {
            int KOD = 0;
            DataRow drbak4 = f.GetDataRow("select AYAR from AYARLAR WHERE AYARTUR='36'");
            if (drbak4 != null)
            {
                string kod = drbak4.ItemArray[0].ToString();
                if (kod != "" && kod != null)
                {
                    try
                    {
                        KOD = Convert.ToInt32(kod);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return Turlar(KOD);
        }

        public static PaperKind Turlar(int KOD)
        {
            PaperKind Tur = new PaperKind();
            if (KOD==0)
            {
                Tur = PaperKind.Custom;
            }
            else if (KOD == 1)
            {
                Tur = PaperKind.Letter;
            }
            else if (KOD == 2)
            {
                Tur = PaperKind.LetterSmall;
            }
            else if (KOD == 3)
            {
                Tur = PaperKind.Tabloid;
            }
            else if (KOD == 4)
            {
                Tur = PaperKind.Ledger;
            }
            else if (KOD == 5)
            {
                Tur = PaperKind.Legal;
            }
            else if (KOD == 6)
            {
                Tur = PaperKind.Statement;
            }
            else if (KOD == 7)
            {
                Tur = PaperKind.Executive;
            }
            else if (KOD == 8)
            {
                Tur = PaperKind.A3;
            }
            else if (KOD == 9)
            {
                Tur = PaperKind.A4;
            }
            else if (KOD == 10)
            {
                Tur = PaperKind.A4Small;
            }
            else if (KOD == 11)
            {
                Tur = PaperKind.A5;
            }
            else if (KOD == 12)
            {
                Tur = PaperKind.B4;
            }
            else if (KOD == 13)
            {
                Tur = PaperKind.B5;
            }
            else if (KOD == 14)
            {
                Tur = PaperKind.Folio;
            }
            else if (KOD == 15)
            {
                Tur = PaperKind.Quarto;
            }
            else if (KOD == 16)
            {
                Tur = PaperKind.Standard10x14;
            }
            else if (KOD == 17)
            {
                Tur = PaperKind.Standard11x17;
            }
            else if (KOD == 18)
            {
                Tur = PaperKind.Note;
            }
            else if (KOD == 19)
            {
                Tur = PaperKind.Number9Envelope;
            }
            else if (KOD == 20)
            {
                Tur = PaperKind.Number10Envelope;
            }
            else if (KOD == 21)
            {
                Tur = PaperKind.Number11Envelope;
            }
            else if (KOD == 22)
            {
                Tur = PaperKind.Number12Envelope;
            }
            else if (KOD == 23)
            {
                Tur = PaperKind.Number14Envelope;
            }
            else if (KOD == 24)
            {
                Tur = PaperKind.CSheet;
            }
            else if (KOD == 25)
            {
                Tur = PaperKind.DSheet;
            }
            else if (KOD == 26)
            {
                Tur = PaperKind.ESheet;
            }
            else if (KOD == 27)
            {
                Tur = PaperKind.DLEnvelope;
            }
            else if (KOD == 28)
            {
                Tur = PaperKind.C5Envelope;
            }
            else if (KOD == 29)
            {
                Tur = PaperKind.C3Envelope;
            }
            else if (KOD == 30)
            {
                Tur = PaperKind.C4Envelope;
            }
            else if (KOD == 31)
            {
                Tur = PaperKind.C6Envelope;
            }
            else if (KOD == 32)
            {
                Tur = PaperKind.C65Envelope;
            }
            else if (KOD == 33)
            {
                Tur = PaperKind.B4Envelope;
            }
            else if (KOD == 34)
            {
                Tur = PaperKind.B5Envelope;
            }
            else if (KOD == 35)
            {
                Tur = PaperKind.B6Envelope;
            }
            else if (KOD == 36)
            {
                Tur = PaperKind.ItalyEnvelope;
            }
            else if (KOD == 37)
            {
                Tur = PaperKind.MonarchEnvelope;
            }
            else if (KOD == 38)
            {
                Tur = PaperKind.PersonalEnvelope;
            }
            else if (KOD == 39)
            {
                Tur = PaperKind.USStandardFanfold;
            }
            else if (KOD == 40)
            {
                Tur = PaperKind.GermanStandardFanfold;
            }
            else if (KOD == 41)
            {
                Tur = PaperKind.GermanLegalFanfold;
            }
            else if (KOD == 42)
            {
                Tur = PaperKind.IsoB4;
            }
            else if (KOD == 43)
            {
                Tur = PaperKind.JapanesePostcard;
            }
            else if (KOD == 44)
            {
                Tur = PaperKind.Standard9x11;
            }
            else if (KOD == 45)
            {
                Tur = PaperKind.Standard10x11;
            }
            else if (KOD == 46)
            {
                Tur = PaperKind.Standard15x11;
            }
            else if (KOD == 47)
            {
                Tur = PaperKind.InviteEnvelope;
            }
            else if (KOD == 50)
            {
                Tur = PaperKind.LetterExtra;
            }
            else if (KOD == 51)
            {
                Tur = PaperKind.LegalExtra;
            }
            else if (KOD == 52)
            {
                Tur = PaperKind.TabloidExtra;
            }
            else if (KOD == 53)
            {
                Tur = PaperKind.A4Extra;
            }
            else if (KOD == 54)
            {
                Tur = PaperKind.LetterTransverse;
            }
            else if (KOD == 55)
            {
                Tur = PaperKind.A4Transverse;
            }
            else if (KOD == 56)
            {
                Tur = PaperKind.LetterExtraTransverse;
            }
            else if (KOD == 57)
            {
                Tur = PaperKind.APlus;
            }
            else if (KOD == 58)
            {
                Tur = PaperKind.BPlus;
            }
            else if (KOD == 59)
            {
                Tur = PaperKind.LetterPlus;
            }
            else if (KOD == 60)
            {
                Tur = PaperKind.A4Plus;
            }
            else if (KOD == 61)
            {
                Tur = PaperKind.A5Transverse;
            }
            else if (KOD == 62)
            {
                Tur = PaperKind.B5Transverse;
            }
            else if (KOD == 63)
            {
                Tur = PaperKind.A3Extra;
            }
            else if (KOD == 64)
            {
                Tur = PaperKind.A5Extra;
            }
            else if (KOD == 65)
            {
                Tur = PaperKind.B5Extra;
            }
            else if (KOD == 66)
            {
                Tur = PaperKind.A2;
            }
            else if (KOD == 67)
            {
                Tur = PaperKind.A3Transverse;
            }
            else if (KOD == 68)
            {
                Tur = PaperKind.A3ExtraTransverse;
            }
            else if (KOD == 69)
            {
                Tur = PaperKind.JapaneseDoublePostcard;
            }
            else if (KOD == 70)
            {
                Tur = PaperKind.A6;
            }
            else if (KOD == 71)
            {
                Tur = PaperKind.JapaneseEnvelopeKakuNumber2;
            }
            else if (KOD == 72)
            {
                Tur = PaperKind.JapaneseEnvelopeKakuNumber3;
            }
            else if (KOD == 73)
            {
                Tur = PaperKind.JapaneseEnvelopeChouNumber3;
            }
            else if (KOD == 74)
            {
                Tur = PaperKind.JapaneseEnvelopeChouNumber4;
            }
            else if (KOD == 75)
            {
                Tur = PaperKind.LetterRotated;
            }
            else if (KOD == 76)
            {
                Tur = PaperKind.A3Rotated;
            }
            else if (KOD == 77)
            {
                Tur = PaperKind.A4Rotated;
            }
            else if (KOD == 78)
            {
                Tur = PaperKind.A5Rotated;
            }
            else if (KOD == 79)
            {
                Tur = PaperKind.B4JisRotated;
            }
            else if (KOD == 80)
            {
                Tur = PaperKind.B5JisRotated;
            }
            else if (KOD == 81)
            {
                Tur = PaperKind.JapanesePostcardRotated;
            }
            else if (KOD == 82)
            {
                Tur = PaperKind.JapaneseDoublePostcardRotated;
            }
            else if (KOD == 83)
            {
                Tur = PaperKind.A6Rotated;
            }
            else if (KOD == 84)
            {
                Tur = PaperKind.JapaneseEnvelopeKakuNumber2Rotated;
            }
            else if (KOD == 85)
            {
                Tur = PaperKind.JapaneseEnvelopeKakuNumber3Rotated;
            }
            else if (KOD == 86)
            {
                Tur = PaperKind.JapaneseEnvelopeChouNumber3Rotated;
            }
            else if (KOD == 87)
            {
                Tur = PaperKind.JapaneseEnvelopeChouNumber4Rotated;
            }
            else if (KOD == 88)
            {
                Tur = PaperKind.B6Jis;
            }
            else if (KOD == 89)
            {
                Tur = PaperKind.B6JisRotated;
            }
            else if (KOD == 90)
            {
                Tur = PaperKind.Standard12x11;
            }
            else if (KOD == 91)
            {
                Tur = PaperKind.JapaneseEnvelopeYouNumber4;
            }
            else if (KOD == 92)
            {
                Tur = PaperKind.JapaneseEnvelopeYouNumber4Rotated;
            }
            else if (KOD == 93)
            {
                Tur = PaperKind.Prc16K;
            }
            else if (KOD == 94)
            {
                Tur = PaperKind.Prc32K;
            }
            else if (KOD == 95)
            {
                Tur = PaperKind.Prc32KBig;
            }
            else if (KOD == 96)
            {
                Tur = PaperKind.PrcEnvelopeNumber1;
            }
            else if (KOD == 97)
            {
                Tur = PaperKind.PrcEnvelopeNumber2;
            }
            else if (KOD == 98)
            {
                Tur = PaperKind.PrcEnvelopeNumber3;
            }
            else if (KOD == 99)
            {
                Tur = PaperKind.PrcEnvelopeNumber4;
            }
            else if (KOD == 100)
            {
                Tur = PaperKind.PrcEnvelopeNumber5;
            }
            else if (KOD == 101)
            {
                Tur = PaperKind.PrcEnvelopeNumber6;
            }
            else if (KOD == 102)
            {
                Tur = PaperKind.PrcEnvelopeNumber7;
            }
            else if (KOD == 103)
            {
                Tur = PaperKind.PrcEnvelopeNumber8;
            }
            else if (KOD == 104)
            {
                Tur = PaperKind.PrcEnvelopeNumber9;
            }
            else if (KOD == 105)
            {
                Tur = PaperKind.PrcEnvelopeNumber10;
            }
            else if (KOD == 106)
            {
                Tur = PaperKind.Prc16KRotated;
            }
            else if (KOD == 107)
            {
                Tur = PaperKind.Prc32KRotated;
            }
            else if (KOD == 108)
            {
                Tur = PaperKind.Prc32KBigRotated;
            }
            else if (KOD == 109)
            {
                Tur = PaperKind.PrcEnvelopeNumber1Rotated;
            }
            else if (KOD == 110)
            {
                Tur = PaperKind.PrcEnvelopeNumber2Rotated;
            }
            else if (KOD == 111)
            {
                Tur = PaperKind.PrcEnvelopeNumber3Rotated;
            }
            else if (KOD == 112)
            {
                Tur = PaperKind.PrcEnvelopeNumber4Rotated;
            }
            else if (KOD == 113)
            {
                Tur = PaperKind.PrcEnvelopeNumber5Rotated;
            }
            else if (KOD == 114)
            {
                Tur = PaperKind.PrcEnvelopeNumber6Rotated;
            }
            else if (KOD == 115)
            {
                Tur = PaperKind.PrcEnvelopeNumber7Rotated;
            }
            else if (KOD == 116)
            {
                Tur = PaperKind.PrcEnvelopeNumber8Rotated;
            }
            else if (KOD == 117)
            {
                Tur = PaperKind.PrcEnvelopeNumber9Rotated;
            }
            else if (KOD == 118)
            {
                Tur = PaperKind.PrcEnvelopeNumber10Rotated;
            }
            return Tur;
        }
    }
}
