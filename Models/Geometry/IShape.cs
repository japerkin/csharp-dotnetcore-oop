/*
 * A Namespace is a way to organize code and prevent naming conflicts. It acts as a container for a group
 * of related classes, structs, interfaces, enums, and delegates. Namespaces help in organizing and
 * categorizing and code logically. You can think of a namespace as a folder that contains related
 * code files.
 *
 * This first line of code is a specific namespace declaration for the "IShape" interface. It indicates that the
 * "IShape" interface is part of the "csharp-dotnetcore-oop.Models.Geometry" namespace. Namespaces are hierarchical, so
 * "csharp-dotnetcore-oop" is the root namespace, and "Models" is a sub-namespace under it, and finally the
 * namespace containing the "IShape" interface is the "Geometry" sub-namespace.
 */
namespace csharp_dotnetcore_oop.Models.Geometry;

public interface IShape
{
    double CalculateArea();
}