using Microsoft.AspNetCore.Mvc;

namespace Neghina_Constantin_Lab1.Controllers
{
    public class Lab1Controller : Controller
    {
        public string Index()
        {
            return "Bun venit tuturor!";
        }

        public string Salut()
        {
            return "Va salut pe toti!";
        }

        public string Info(string nume, int varsta)
        {
            return "Numele este " + nume + " si are " + varsta + " ani.";
        }

    }
}
