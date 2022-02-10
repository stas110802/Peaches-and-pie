using JPega.Composition_and_aggregation;
using JPega.TPL__Task_Parallel_Library_;

#region Composition and aggregation

//var freshener = new Freshener();
//var car = new Car(freshener);
//car.Drive();

#endregion
#region TPL (Task Parallel Library)

var tpl = new CustomTPL();
tpl.CreateTwoTask();

#endregion