using System;
using System.Collections.Generic;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ChurchModes
{
    public partial class Form1 : Form

    {
        private string postFix;
        private string keyNote;
        private string keyNoteNull;
        private string newKey;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboState.Items.Clear();
            List<RootNotes> list = new List<RootNotes>();
            list.Add(new RootNotes() { ID = "01", Name = "C" });
            list.Add(new RootNotes() { ID = "02", Name = "D" });
            list.Add(new RootNotes() { ID = "03", Name = "E" });
            list.Add(new RootNotes() { ID = "04", Name = "F" });
            list.Add(new RootNotes() { ID = "05", Name = "G" });
            list.Add(new RootNotes() { ID = "06", Name = "A" });
            list.Add(new RootNotes() { ID = "07", Name = "B" });
            cboState.DataSource = list;
            cboState.ValueMember = "ID";
            cboState.DisplayMember = "name";
            cboState.SelectedIndex = 4;
        }

        private void isSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (isSharp.Checked)
            {
                this.postFix = "#";
                this.keyNote = cboState.Text + postFix;
            }
        }

        private void isFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (isFlat.Checked)
            {
                this.postFix = "b";
                this.keyNote = cboState.Text + postFix;
            }
        }

        private void isNone_CheckedChanged(object sender, EventArgs e)
        {
            if (isNone.Checked)
            {
                this.postFix = "";
                this.keyNote = cboState.Text + postFix;
            }
        }
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

            RootNotes obj = cboState.SelectedItem as RootNotes;
            if (obj != null)
            {
                this.keyNote = cboState.Text + postFix;
                this.keyNoteNull = cboState.Text;
            }
        }

        private void dorian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "W H W W W H W";
            ScaleName.Text = "Dorian";
            mode.Text = "m7";

            ChurchModes churchModes = new ChurchModes(keyNote);

            newKey = churchModes.dorian;
            Dorian dorian = new Dorian(newKey);
            scaleNotes.Text = dorian.dorianScale;

            Dorian dorianKey = new Dorian(keyNote);
            scaleNotesKey.Text = dorianKey.dorianScale;

            degree_I.Text = dorianKey.tonic;
            degree_IV.Text = dorianKey.subDom;
            degree_V.Text = dorianKey.dominant;
        }

        private void phrygian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "H W W W H W W";
            ScaleName.Text = "Phrygian";
            mode.Text = "m7";

            ChurchModes churchModes = new ChurchModes(keyNote);
            newKey = churchModes.phrygian;

            Phrygian phrygian = new Phrygian(newKey);
            scaleNotes.Text = phrygian.phrygianScale;

            Phrygian phrygianKey = new Phrygian(keyNote);
            scaleNotesKey.Text = phrygianKey.phrygianScale;

            degree_I.Text = phrygianKey.tonic;
            degree_IV.Text = phrygianKey.subDom;
            degree_V.Text = phrygianKey.dominant;
        }

        private void lydian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "W W W H W W H";
            ScaleName.Text = "Lydian";
            mode.Text = "MA7";
            ChurchModes churchModes = new ChurchModes(keyNote);
            newKey = churchModes.lydian;
            Lydian lydian = new Lydian(newKey);
            scaleNotes.Text = lydian.lydianScale;

            Lydian lydianKey = new Lydian(keyNote);
            scaleNotesKey.Text = lydianKey.lydianScale;

            degree_I.Text = lydianKey.tonic;
            degree_IV.Text = lydianKey.subDom;
            degree_V.Text = lydianKey.dominant;

        }

        private void mixoLydian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "W W H W W H W";
            ScaleName.Text = "Mixolydian";
            mode.Text = "dom 7";
            ChurchModes churchModes = new ChurchModes(keyNote);
            newKey = churchModes.mixolydian;
            Mixolydian mixolydian = new Mixolydian(newKey);
            scaleNotes.Text = mixolydian.mixolydianScale;

            Mixolydian mixolydianKey = new Mixolydian(keyNote);
            scaleNotesKey.Text = mixolydianKey.mixolydianScale;

            degree_I.Text = mixolydianKey.tonic;
            degree_IV.Text = mixolydianKey.subDom;
            degree_V.Text = mixolydianKey.dominant;
        }

        private void aeolian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "W W H W W W H";
            ScaleName.Text = "Aeolian";
            mode.Text = "m7";
            ChurchModes churchModes = new ChurchModes(keyNote);
            newKey = churchModes.aeolian;
            Aeolian aeolian = new Aeolian(newKey);
            scaleNotes.Text = aeolian.aeolianScale;

            Aeolian aeolianKey = new Aeolian(keyNote);
            scaleNotesKey.Text = aeolianKey.aeolianScale;

            degree_I.Text = aeolianKey.tonic;
            degree_IV.Text = aeolianKey.subDom;
            degree_V.Text = aeolianKey.dominant;
        }

        private void locrian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "W W H W W W H";
            ScaleName.Text = "Locrian";
            mode.Text = "m7b5";
            ChurchModes churchModes = new ChurchModes(keyNote);
            newKey = churchModes.locrian;
            Locrian locrian = new Locrian(newKey);
            scaleNotes.Text = locrian.locrianScale;

            Locrian locrianKey = new Locrian(keyNote);
            scaleNotesKey.Text = locrianKey.locrianScale;

            degree_I.Text = locrianKey.tonic;
            degree_IV.Text = locrianKey.subDom;
            degree_V.Text = locrianKey.dominant;
        }

        private void ionian_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;
            Intervals.Text = "W W H W W W H";
            ScaleName.Text = "Ionian";
            mode.Text = "MA7";
            Ionian ionian = new Ionian(keyNote);
            scaleNotes.Text = ionian.ionianScale;
            scaleNotesKey.Text = ionian.ionianScale;

            Ionian ionianKey = new Ionian(keyNote);
            scaleNotesKey.Text = ionianKey.ionianScale;

            degree_I.Text = ionianKey.tonic;
            degree_IV.Text = ionianKey.subDom;
            degree_V.Text = ionianKey.dominant;

        }
    }
}
