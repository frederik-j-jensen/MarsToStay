namespace MarsToStayTest.EntityFramework;

public class RepositoryTest
{
    [Fact]
    public async void CreateAndFindById()
    {
        var repo = new Repository<Entity>();
        var entity = await repo.Create();
        var found = await repo.FindById(entity.Id);
        Assert.Equal(entity, found);
    }
}