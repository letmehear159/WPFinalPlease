using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFinalPlease
{
    internal class Worker : Person
    {

        private string occupation;
        private int experiencedYear;
        private double expectedPrice;
        private string certificate;
        private float starRate;
        private int reviewAmount;
        private string skills;
        private string bio;

        public Worker(string name, string cccd, string address, string gender, string phone, string email, DateTime birth,
            string occupation, int experiencedYear, double expectedPrice, string certificate, float starRate,
            int reviewAmount, string skills, string bio
            ) : base(name, cccd, address, gender, phone, email, birth)
        {
            this.occupation = occupation;
            this.experiencedYear = experiencedYear;
            this.expectedPrice = expectedPrice;
            this.certificate = certificate;
            this.starRate = starRate;
            this.skills = skills;
            this.bio = bio;
            this.reviewAmount = reviewAmount;

        }
        public Worker(string occupation, int experiencedYear, double expectedPrice, string certificate)
       : base()
        {
            this.occupation = occupation;
            this.experiencedYear = experiencedYear;
            this.expectedPrice = expectedPrice;
            this.certificate = certificate;
            // Các thuộc tính khác sẽ tự động được gán giá trị mặc định (null) vì chúng không được gán trong constructor này
        }
       

        // Get methods for each property

        public string GetOccupation()
        {
            return occupation;
        }

        public int GetExperiencedYear()
        {
            return experiencedYear;
        }

        public double GetExpectedPrice()
        {
            return expectedPrice;
        }
        public string GetCertificate()
        {
            return certificate;
        }

        public float GetStarRate()
        {
            return starRate;
        }

        public int GetReviewAmount()
        {
            return reviewAmount;
        }

        public string GetSkills()
        {
            return skills;
        }

        public string GetBio()
        {
            return bio;
        }



    }
}
