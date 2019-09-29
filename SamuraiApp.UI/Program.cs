using System;
using SamuraiApp.Migrations.SqlServer;

namespace SamuraiApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndSelectDataExamples manager = new CreateAndSelectDataExamples();
            int count; 
            
            //manager.Context.Database.EnsureCreated();
            //manager.DeleteTestData();
            //manager.InitTestData();
            //manager.Context.SaveChanges();

            //manager.InsertSamurai();
            //manager.SimpleSamuraiQuery();
            //manager.MoreSimpleSamuraiQuery();
            //manager.RetriveAndUpdateSamurai();
            //manager.DeletingTheObject();
            //manager.RowSqlQuery();
            //manager.RunStoredProcedure();
            //manager.RunFunctionProcedure();
            //manager.InsertNewPkgGraph();
            //manager.InsertNewItemsIntoPkgGraph();
            //manager.InsertOneToOneRelation();
            //manager.EagerLoadingWithInclude();
            //manager.EagerLoadManyToManyAkaChildrenGrandChildren();
            //manager.AnonymousTypeVisProjections();
            //manager.AnonymousTypeVisProjectionsWithRelated();
            //manager.RelatedObjectsFixUp();
            //manager.EagerLoadViaProjections();
            //manager.ExplicitLoad();
            manager.ExplicitLoadWithChildFilter();
        }
    }
}
