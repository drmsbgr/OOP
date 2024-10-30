using UniversityApp.Models;

var students = new List<Student>(){
    new LicenceStudent("Ali,","Veli",2),
    new LicenceStudent("Buğra","Durmuş",13563837,"Yazılım Mühendisliği",2),
    new DegreeStudent("Mehmet","Yılmaz","Erol Er"),
    new DegreeStudent("Mustafa","Kumru",1234421,"Biyomedikal Mühendisliği","Emine Yılmaz"),
    new DoctorateStudent("Berkay","Öztürk","Kanser Üzerine Araştırmalar"),
    new DoctorateStudent("Sami","Eroğlu",3783721,"Endüstri Mühendisliği","Yüksem Verim Sağlamanın Yolları"),
};

students.ForEach(s => Console.WriteLine(s.GetInfo()));
var ls = (LicenceStudent)students[0];
ls.PrintSubjects();

var dc =(DoctorateStudent)students[4];
dc.GetAdvisorReport();