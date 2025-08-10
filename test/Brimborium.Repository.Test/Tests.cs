
namespace Brimborium.Repository;

public class Tests {
    [Test]
    public async Task Test001() {
        SuberHeroRepositorySet repositorySet = new();
        repositorySet.SuberHero.Attach(new SuberHero(1, "one"));
        await Task.CompletedTask;
    }
}

public class SuberHeroRepositorySet :RepositorySet {
    private SuberHeroRepository _SuberHero;
    
    public SuberHeroRepositorySet() {
        this._SuberHero = new();
    }

    public SuberHeroRepository SuberHero => _SuberHero
}

public class SuberHeroRepository : TypedRepository<SuberHero> {
    public void Attach(SuberHero suberHero) {
        throw new NotImplementedException();
    }
}

public record SuberHero(
    int SuberHeroId,
    string Name
);

public record struct SuberHeroPK(
    int SuberHeroId
);