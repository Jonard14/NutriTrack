using Android.Animation;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using System;
using AndroidX.Fragment.App;
using System.Collections;
using static Android.Provider.DocumentsContract;
using System.Text.Json;

namespace App1
{

    public class NutritionFragment : AndroidX.Fragment.App.Fragment
    {
        JsonElement root;
        DBClass db = new DBClass();

        string searchemail, gender;
        string email = Login.MyGlobals.Globalemail, birthday;
        float CalorieNum, TotalCalorie, CalorieDays, total_sugar = 0, currentCalorieNum = 0, prog = 0;
        Button SaveCalorie, ResetSugar;
        double recommendCalorie, age, height, weight;
        float protein, fat, cholesterol, carbohydrates, sodium, d;

        ProgressBar pieChart;

        private ListView lv;
        private ArrayList history;
        private ArrayAdapter _adapter;

        TextView PrevCalorie, SugarCount, numOfCal, Tprotein, Tcholesterol, Tsodium, Tcarbohydrates, Tfats;
        LinearLayout estim;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Fragment specific initialization goes here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
        
            // Inflate the layout for this fragment
            View view = inflater.Inflate(Resource.Layout.fragment_nutrition, container, false);

            // Initialize UI elements
            estim = view.FindViewById<LinearLayout>(Resource.Id.linearLayout5);
            PrevCalorie = view.FindViewById<TextView>(Resource.Id.textV_NumPrev);
            SugarCount = view.FindViewById<TextView>(Resource.Id.textV_NumSugar);
            numOfCal = view.FindViewById<TextView>(Resource.Id.number_of_calories);
            pieChart = view.FindViewById<ProgressBar>(Resource.Id.stats_progressbar);
            SaveCalorie = view.FindViewById<Button>(Resource.Id.btn_saveCalorie);
            //ResetSugar = view.FindViewById<Button>(Resource.Id.btnn_resetSugar);
            lv = view.FindViewById<ListView>(Resource.Id.listview1);
            Tprotein = view.FindViewById<TextView>(Resource.Id.textV_numprotein);
            Tcholesterol = view.FindViewById<TextView>(Resource.Id.textV_numcholesterol);
            Tsodium = view.FindViewById<TextView>(Resource.Id.textV_numsodium);
            Tcarbohydrates = view.FindViewById<TextView>(Resource.Id.textV_numcarbohydrates);
            Tfats = view.FindViewById<TextView>(Resource.Id.textV_numfats);

            // Set up event handlers
            SaveCalorie.Click += saveCalorieClick;
            //ResetSugar.Click += resetSugarCalorie;
            estim.Click += estimClick;

            history = new ArrayList();

            // Update UI with the latest data
            Update();

            return view;
        }

        private void estimClick(object sender, EventArgs e)
        {
            Toast.MakeText(Activity, "Use the app daily to get accurate results", ToastLength.Long).Show();
        }

        public void Update()
        {
            total_sugar += Login.MyGlobals.GlobalSugar;
            currentCalorieNum += Login.MyGlobals.GlobalCalorie;
            protein += Login.MyGlobals.GlobalProtein;
            fat += Login.MyGlobals.GlobalFat;
            cholesterol += Login.MyGlobals.GlobalCholesterol;
            carbohydrates += Login.MyGlobals.GlobalCarbohyrates;
            sodium += Login.MyGlobals.GlobalSodium;
            // Save global data
            TempDataService.SaveGlobalData();

            if (VerifyEmail())
            {
                PrevCalorie.Text = Math.Round(CalorieNum, 0).ToString();

                if (currentCalorieNum != 0)
                {
                    SugarCount.Text = Math.Round(((total_sugar * 4) / currentCalorieNum) * 100, 0).ToString() + "%";
                    Tprotein.Text = Math.Round(((protein * 4) / currentCalorieNum) * 100, 0).ToString() + "%";
                    Tfats.Text = Math.Round(((fat * 9) / currentCalorieNum) * 100, 0).ToString() + "%";
                    Tcarbohydrates.Text = Math.Round(((carbohydrates * 4) / currentCalorieNum) * 100, 0).ToString() + "%";
                }
                else
                {
                    SugarCount.Text = "0%";
                    Tprotein.Text = "0%";
                    Tcarbohydrates.Text = "0%";
                    Tfats.Text = "0%";
                }

                Tcholesterol.Text = Math.Round(cholesterol, 0).ToString() + "mg";
                Tsodium.Text = Math.Round(sodium, 0).ToString() + "mg";
            }
            else
            {
                Toast.MakeText(Activity, "Unable to Retrieve Data", ToastLength.Long).Show();
            }
            dailyCalorieCalcualte();
        }

        public void saveCalorieClick(object sender, EventArgs e)
        {

            if (NullValue() && VerifyEmail())
            {
                float totalCalNum = TotalCalorie;
                float currentCal = currentCalorieNum;
                float calorieDays = CalorieDays;
                calorieDays = calorieDays + 1;

                float prevCal = CalorieNum;
                prevCal = (currentCal + totalCalNum) / calorieDays;

                string prevCalString = prevCal.ToString();
                string stringCalDays = calorieDays.ToString();
                TotalCalorie = currentCal + totalCalNum;

                //db.InsertData("update_calorie.php?email=" + email + "&daily_calorie_intake=" + prevCalString + "&total_calorie_intake=" + TotalCalorie + "&calorie_intake_days=" + stringCalDays);
                db.InsertDataAzure("UPDATE user_data SET daily_calorie_intake='" + float.Parse(prevCalString) + "', total_calorie_intake='" + TotalCalorie + "', calorie_intake_days='" + float.Parse(stringCalDays) + "' WHERE email='" + email + "';", "user_db");
                PrevCalorie.Text = TotalCalorie.ToString();


                string tracker_log_time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm\:ss tt");
                //history.Add(tracker_log_time + "\nCalorie Count: " + CurrentCalorie.Text + "\nSugar Count: " + SugarCount.Text);
                //string success = db.InsertData("insert_trackerlog.php?email=" + email + "&time_log=" + tracker_log_time + "&calorie_count=" + currentCalorieNum + "&sugar_count=" + SugarCount.Text + "&protein_count=" + Tprotein.Text + "&fats_count=" + Tfats.Text + "&cholesterol_count=" + Tcholesterol.Text + "&carbohydrates_count=" + Tcarbohydrates.Text + "&sodium_count=" + Tsodium.Text);

                string success2 = db.InsertDataAzure("INSERT INTO tracker_log VALUES (" + "'" + email + "'" + "," + "'" + tracker_log_time + "'" + "," + "'" + Login.MyGlobals.GlobalCalorie + "'" + "," +
                                                               "'" + Login.MyGlobals.GlobalSugar + "'" + "," + "'" + Login.MyGlobals.GlobalProtein + "'" + "," + "'" + Login.MyGlobals.GlobalFat + "'" + "," +
                                                               "'" + Login.MyGlobals.GlobalCholesterol + "'" + "," + "'" + Login.MyGlobals.GlobalCarbohyrates + "'" + "," + "'" +
                                                               Login.MyGlobals.GlobalSodium + "'" + ");", "user_db");
                //Console.WriteLine(success);
                Console.WriteLine(success2);
                resetSugarCalorie();

                Toast.MakeText(Activity, "Successfuly saved Progress!", ToastLength.Long).Show();
            }
            else
                Toast.MakeText(Activity, "No Progress to save!", ToastLength.Long).Show();

        }

        public void resetSugarCalorie()
        {
            numOfCal.Text = "0" + "/" + Math.Round(recommendCalorie, 0).ToString();
            pieChart.Progress = 0;

            SugarCount.Text = "0";
            //CurrentCalorie.Text = "0";
            Tprotein.Text = "0";
            Tcarbohydrates.Text = "0";
            Tsodium.Text = "0";
            Tfats.Text = "0";
            Tcholesterol.Text = "0";

            Login.MyGlobals.GlobalSugar = 0;
            Login.MyGlobals.GlobalCalorie = 0;
            Login.MyGlobals.GlobalProtein = 0;
            Login.MyGlobals.GlobalFat = 0;
            Login.MyGlobals.GlobalCholesterol = 0;
            Login.MyGlobals.GlobalCarbohyrates = 0;
            Login.MyGlobals.GlobalSodium = 0;
            Login.MyGlobals.GlobalFoodList.Clear();

            total_sugar += Login.MyGlobals.GlobalSugar;
            currentCalorieNum += Login.MyGlobals.GlobalCalorie;
            protein += Login.MyGlobals.GlobalProtein;
            fat += Login.MyGlobals.GlobalFat;
            cholesterol += Login.MyGlobals.GlobalCholesterol;
            carbohydrates += Login.MyGlobals.GlobalCarbohyrates;
            sodium += Login.MyGlobals.GlobalSodium;
            // Save global data
            TempDataService.SaveGlobalData();
           

        }

        public bool NullValue()
        {
            if (Login.MyGlobals.GlobalCalorie == 0 && Login.MyGlobals.GlobalSugar == 0 && Login.MyGlobals.GlobalProtein == 0 && Login.MyGlobals.GlobalFat == 0 && Login.MyGlobals.GlobalCholesterol == 0 && Login.MyGlobals.GlobalCarbohyrates == 0 && Login.MyGlobals.GlobalSodium == 0)
            {
                return false;
            }
            else
                return true;
        }
        public bool VerifyEmail()
        {
            //root = db.RetrieveData("get_calorie.php?email=" + email);
            root = db.RetrieveDataAzure("SELECT * FROM user_data WHERE email='" + email + "';", null, "user_db");

            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                searchemail = u1.GetProperty("email").ToString();
                CalorieNum = float.Parse(u1.GetProperty("daily_calorie_intake").ToString());
                TotalCalorie = float.Parse(u1.GetProperty("total_calorie_intake").ToString());
                CalorieDays = float.Parse(u1.GetProperty("calorie_intake_days").ToString());
                birthday = u1.GetProperty("birthday").ToString();
                height = double.Parse(u1.GetProperty("height").ToString());
                weight = double.Parse(u1.GetProperty("weight").ToString());
                gender = u1.GetProperty("gender").ToString();
                if (searchemail == email)
                { return true; }
            }
            return false;
        }

        public double ConvertBirthdayToAge() // Convert Birthday to Age
        {
            /* Jonard's Note:
            This will accurately get the age especially if the month or day was passed or not. 
            *(my explanation is bad lol so here's the example)
            *
            Example: User's birthday is 2024-06-20
                Then, if the date is 2001-06-21. Therefore, user's age is 23
                Then, if the date is 2001-06-19. Therefore, user's age is 22 because it haven't reached their birthday for this year
             */
            string[] birthdate_split = new string[2];
            birthdate_split = birthday.Split('-'); // YYYY-MM-DD

            if (Int32.Parse(birthdate_split[1]) < DateTime.Now.Month ||
                (Int32.Parse(birthdate_split[1]) == DateTime.Now.Month && Int32.Parse(birthdate_split[2]) < DateTime.Now.Day))
                return (DateTime.Now.Year - Int32.Parse(birthdate_split[0])) - 1;
            return DateTime.Now.Year - Int32.Parse(birthdate_split[0]);
        }

        public void dailyCalorieCalcualte()
        {
            age = ConvertBirthdayToAge();
            //Females: (10*weight [kg]) + (6.25*height [cm]) – (5*age [years]) – 161
            //Males: (10 * weight[kg]) + (6.25 * height[cm]) – (5 * age[years]) + 5

            height = height * 100; //convert meter to cm

            if (gender == "M")
            {
                recommendCalorie = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                //recommendNum.Text = recommendCalorie.ToString();

            }
            else if (gender == "F")
            {
                recommendCalorie = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                //recommendNum.Text = recommendCalorie.ToString();
            }
            //Update chart
            numOfCal.Text = Math.Round(currentCalorieNum, 0).ToString() + "/" + Math.Round(recommendCalorie, 0).ToString();
            d = currentCalorieNum / (float)recommendCalorie;
            prog = d * 100;
            pieChart.Progress = (int)prog;
            // Animate the progress bar
            // Create a ValueAnimator to animate the progress
            ValueAnimator animator = ValueAnimator.OfInt(0, (int)prog);
            animator.SetDuration(1000); // 1 second
            animator.SetInterpolator(new DecelerateInterpolator()); // For smooth animation
            animator.Update += (object sender, ValueAnimator.AnimatorUpdateEventArgs e) =>
            {
                int animatedValue = (int)e.Animation.AnimatedValue;
                pieChart.Progress = animatedValue;
            };
            animator.Start();
        }

    }
}
