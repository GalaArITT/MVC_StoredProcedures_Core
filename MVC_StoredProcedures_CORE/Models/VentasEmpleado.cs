using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_StoredProcedures_CORE.Models
{
    public class VentasEmpleado
    {
        //solo se agregan los datos del SP 
        /*
         create procedure sp_ventas_empleado
            as 
            begin 
	            select e.FirstName + ' '+ e.LastName as nombre_completo, 
	            count(o.OrderID) as ordenes_vendidas from Employees e 
	            inner join Orders o
	            on o.EmployeeID = e.EmployeeID
	            group by e.FirstName, e.LastName
            end 
         */
        public string nombre_completo { get; set; }
        public int ordenes_vendidas { get; set; }

    }
}
