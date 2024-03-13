public class LimitedObjectsCreation
{
    private static int instanceCount = 1;
    private static readonly int maxInstances = 5;

    // Private constructor to prevent direct instantiation
    private LimitedObjectsCreation()
    {
        // Increment the instance count when an object is created
        instanceCount++;
    }

    // Factory method to create instances and enforce the limit
    public static LimitedObjectsCreation CreateObject()
    {
        if (instanceCount <= maxInstances)
        {
            Console.WriteLine($"{instanceCount} Object created successfully");
            return new LimitedObjectsCreation();
        }
        else
        {
            // Optionally, you can throw an exception or handle the situation in another way
            Console.WriteLine($"Cannot create more object. Maximum limit {maxInstances} reached.");
            return null;
        }
    }
}