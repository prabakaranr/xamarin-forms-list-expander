using System;
using System.Collections.Generic;
using Expander.Model;

namespace Expander.ViewModel
{
    public class MainPageViewModel
    {
        const string description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc pretium commodo augue, sit amet rutrum erat lobortis sit amet.Phasellus non lacinia lorem.Vivamus vestibulum gravida lobortis.";

        const string imagePath = "report.png";

        public List<Report> Data { get; set; }

        public MainPageViewModel()
        {
            Data = new List<Report>();

            Data.Add(new Report("1234", description, imagePath));
            Data.Add(new Report("1235", description, imagePath));
            Data.Add(new Report("1236", description, imagePath));
            Data.Add(new Report("1237", description, imagePath));
            Data.Add(new Report("1238", description, imagePath));
            Data.Add(new Report("1239", description, imagePath));
            Data.Add(new Report("1240", description, imagePath));
            Data.Add(new Report("1241", description, imagePath));
            Data.Add(new Report("1242", description, imagePath));
            Data.Add(new Report("1243", description, imagePath));
            Data.Add(new Report("1244", description, imagePath));
            Data.Add(new Report("1245", description, imagePath));
            Data.Add(new Report("1246", description, imagePath));

        }
    }
}
