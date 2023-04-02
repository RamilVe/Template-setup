using System.Collections.Generic;

namespace BizLand.Models
{
    public class Data
    {
       public static List<Service> Services = new List<Service>
       {
           new Service{Id=1, Icon="<i class=\"bx bxl-dribbble\"></i>", Title="Lorem Ipsum", Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
           new Service{Id=2, Icon="<i class=\"bx bx-file\"></i>", Title="Sed ut perspiciatis", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
           new Service{Id=3, Icon="<i class=\"bx bx-tachometer\"></i>", Title="Magni Dolores", Desc="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
           new Service{Id=4, Icon="<i class=\"bx bx-world\"></i>", Title="Nemo Enim", Desc="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
           new Service{Id=5, Icon="<i class=\"bx bx-slideshow\"></i>", Title="Dele cardo", Desc="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
           new Service{Id=6, Icon="<i class=\"bx bx-arch\"></i>", Title="Divera don", Desc="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"}
       };
       public static List<Team> Members = new List<Team>
       {
            new Team{Id=1,Image="team-1.jpg", Fullname="Walter White", Desc="Chief Executive Officer", Icon1="<i class=\"bi bi-twitter\"></i>", Icon2="<i class=\"bi bi-facebook\"></i>", Icon3="<i class=\"bi bi-instagram\"></i>", Icon4="<i class=\"bi bi-linkedin\"></i>"},
            new Team{Id=2,Image="team-2.jpg", Fullname="Sarah Jhonson", Desc="Product Manager", Icon1="<i class=\"bi bi-twitter\"></i>", Icon2="<i class=\"bi bi-facebook\"></i>", Icon3="<i class=\"bi bi-instagram\"></i>", Icon4="<i class=\"bi bi-linkedin\"></i>"},
            new Team{Id=3,Image="team-3.jpg", Fullname="William Anderson", Desc="CTO", Icon1="<i class=\"bi bi-twitter\"></i>", Icon2="<i class=\"bi bi-facebook\"></i>", Icon3="<i class=\"bi bi-instagram\"></i>", Icon4="<i class=\"bi bi-linkedin\"></i>"},
            new Team{Id=4,Image="team-4.jpg", Fullname="Amanda Jepson", Desc="Accountant", Icon1="<i class=\"bi bi-twitter\"></i>", Icon2="<i class=\"bi bi-facebook\"></i>", Icon3="<i class=\"bi bi-instagram\"></i>", Icon4="<i class=\"bi bi-linkedin\"></i>"},
       };
    }
}
