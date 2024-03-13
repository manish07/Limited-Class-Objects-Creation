# Limited-Class-Objects-Creation
Control the number of instances/objects creation for class in c#

1. Private constructor --> `LimitedObjectsCreation` : Class has a private constructor, preventing direct instantiation.
2. Static field to track the number of instances --> `instanceCount` and `maxInstances` are static fields.
   * `instanceCount` : Tracks the number of instances created
   * `maxInstances` : Specifies the maximum allowed instances.
4. Factory method : The `CreateObject` method acts as a factory method. It checks whether the maximum limit has been reached before creating a new instance/object.

