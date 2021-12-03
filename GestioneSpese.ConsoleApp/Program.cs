// See https://aka.ms/new-console-template for more information

/* metodo per restituire le spese del mese precedente
public IEnumerable<Expense> FetchExpensesApprovedLastMonth()
{
    var result = _expensesRepo
    .Fetch(e => e.Approved
    && e.Date >= DateTime.Today.AddDays(-DateTime.Today.Day + 1).AddMonths(-1)
    && e.Date <= DateTime.Today.AddDays(-DateTime.Today.Day)
    );
    return result;
} */


Console.WriteLine("Hello, World!");
