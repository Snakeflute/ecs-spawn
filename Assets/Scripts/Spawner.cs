using Unity.Entities;

public struct Spawner : IComponentData {
    public int CountX;
    public int CountY;
    public Entity Prefab;
}