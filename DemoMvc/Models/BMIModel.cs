namespace DemoMVC.Models
{
    public class BMIModel
    {
        public double Height { get; set; } // Chiều cao (m)
        public double Weight { get; set; } // Cân nặng (kg)

        public double CalculateBMI()
        {
            if (Height > 0)
                return Weight / (Height * Height);
            return 0;
        }

        public string GetBMICategory()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5) return "Gầy";
            if (bmi < 24.9) return "Bình thường";
            if (bmi < 29.9) return "Thừa cân";
            return "Béo phì";
        }
    }
}
