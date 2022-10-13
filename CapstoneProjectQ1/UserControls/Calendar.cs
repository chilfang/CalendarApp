using CapstoneProjectQ1.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapstoneProjectQ1 {
    public partial class Calendar : UserControl {
        private NavigationControl navigationControl;

        private SolidBrush inactiveDay = new SolidBrush(Color.Gray);
        private SolidBrush activeDay = new SolidBrush(Color.White);
        private SolidBrush border = new SolidBrush(Color.Black);

        private int leadingDays;
        private int monthDays;
        private int trailingDays;

        private Date[] dates;

        private int boxWidth;
        private int boxHeight;

        private DateTime currentDate = DateTime.Today;

        private int columns = 7;
        private int rows = 6;

        public Calendar(NavigationControl navigationControl) {
            InitializeComponent();
            this.navigationControl = navigationControl;

            boxWidth = Width / columns;
            boxHeight = 90;

            LoadMonth();
        }

        private void LoadMonth(int offset = 0) {
            if (offset != 0) currentDate = currentDate.AddMonths(offset);

            //Sets label to current month
            CurrentMonthLabel.Text = currentDate.ToString("MMMM yyyy");

            //Gets the different date types to display
            leadingDays = ((int) new DateTime(currentDate.Year, currentDate.Month, 1).DayOfWeek);
            monthDays = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            trailingDays = (columns * rows) - monthDays - leadingDays;

            while (leadingDays + monthDays + trailingDays < 42) { trailingDays++; }

            dates = new Date[42];

            //Displays date
            int[] displayDates = new int[42];

            for (int i = 0; i < leadingDays; i++) { //add leading dates
                displayDates[i] = DateTime.DaysInMonth(currentDate.AddMonths(-1).Year, currentDate.AddMonths(-1).Month) - leadingDays + i + 1;
            }
            for (int i = 0; i < monthDays; i++) { // add current month
                displayDates[i + leadingDays] = i + 1;
            }
            for (int i = 0; i < trailingDays; i++) { // add trailing days
                displayDates[i + leadingDays + monthDays] = i + 1;
            }

            //Make boxes on calendar
            for (int x = 0; x < columns; x++) {
                for (int y = 0; y < rows; y++) {
                    if (x + (columns * y) < leadingDays) { // Leading days
                        Date dateControl = new Date(new DateTime(currentDate.AddMonths(-1).Year, currentDate.AddMonths(-1).Month, displayDates[(x + (columns * y))])) {
                            Location = new Point(x * boxWidth + 6, (y * boxHeight) + 23 + boxHeight),
                            Parent = this,
                        };

                        dateControl.BackColor = inactiveDay.Color;
                        dateControl.active = false;

                        dates[x + (columns * y)] = dateControl;

                    } else if (x + (columns * y) >= leadingDays + monthDays) { // Trailing Days
                        Date dateControl = new Date(new DateTime(currentDate.AddMonths(1).Year, currentDate.AddMonths(1).Month, displayDates[(x + (columns * y))])) {
                            Location = new Point(x * boxWidth + 6, (y * boxHeight) + 23 + boxHeight),
                            Parent = this,
                        };

                        dateControl.BackColor = inactiveDay.Color;
                        dateControl.active = false;

                        dates[x + (columns * y)] = dateControl;

                    } else { // Current Month
                        Date dateControl = new Date(new DateTime(currentDate.Year, currentDate.Month, displayDates[(x + (columns * y))])) {
                            Location = new Point(x * boxWidth + 6, (y * boxHeight) + 23 + boxHeight),
                            Parent = this,
                        };

                        dateControl.BackColor = activeDay.Color;
                        dateControl.active = true;

                        dates[x + (columns * y)] = dateControl;
                    }

                }
            }

        }

        private void Calendar_Paint(object sender, PaintEventArgs pe) {
            using (Graphics graphics = pe.Graphics) {

                //Make border
                using (Pen penBorder = new Pen(border, 6F)) {
                    for (int x = 0; x < columns; x++) {
                        for (int y = 0; y < rows; y++) {
                            Rectangle rect = new Rectangle(x * boxWidth + 3, Height - (y * boxHeight) - boxHeight - 3, boxWidth, boxHeight);

                            graphics.DrawRectangle(penBorder, rect);
                        }
                    }
                }

                //Month Background
                graphics.FillRectangle(activeDay,
                    CurrentMonthLabel.Location.X + 40,
                    CurrentMonthLabel.Location.Y + 14,
                    CurrentMonthLabel.Size.Width - 90,
                    CurrentMonthLabel.Size.Height - 10
                );
                //Left circle
                graphics.FillEllipse(activeDay,
                    CurrentMonthLabel.Location.X - 10,
                    CurrentMonthLabel.Location.Y + 13,
                    90,
                    CurrentMonthLabel.Size.Height - 9
                );
                //Right circle
                graphics.FillEllipse(activeDay,
                    CurrentMonthLabel.Location.X + CurrentMonthLabel.Size.Width - 90,
                    CurrentMonthLabel.Location.Y + 13,
                    90,
                    CurrentMonthLabel.Size.Height - 9
                );


            }

        }

        public void ChangeCalendarColors(Color activeDay = default(Color), Color inactiveDay = default(Color), Color border = default(Color), Color note = default(Color)) {
            if (activeDay != default(Color)) { // change current month color
                this.activeDay = new SolidBrush(activeDay);
                foreach (Date date in dates) {
                    if (date.active) {
                        date.BackColor = activeDay;
                    }
                }
            }

            if (inactiveDay != default(Color)) { // change other month color
                this.inactiveDay = new SolidBrush(inactiveDay);
                foreach (Date date in dates) {
                    if (!date.active) {
                        date.BackColor = inactiveDay;
                    }
                }
            }

            if (border != default(Color)) { this.border = new SolidBrush(border); } // change border color

            if (note != default(Color)) { // change note color
                foreach (Date date in dates) {
                    date.noteDisplayButton.BackColor = note;
                }
            }
        }

        private void ArrowRightPicture_Click(object sender, EventArgs e) {
            ClearMonth();
            LoadMonth(1);
        }

        private void ArrowLeftPicture_Click(object sender, EventArgs e) {
            ClearMonth();
            LoadMonth(-1);
        }

        private void ClearMonth() { // clears the dates from the Calendar in preperation of loading a different month
            foreach (Date date in dates) {
                date.Dispose();
            }
        }
    }
}
