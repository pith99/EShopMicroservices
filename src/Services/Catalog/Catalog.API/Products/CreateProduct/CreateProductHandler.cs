using MediatR;
using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;

//This record is used to define the input parameters for the CreateProductHandler (Data to create new product)
public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;

//This record is used to define the output parameters for the CreateProductHandler (Return object with the Id of the new product)
public record CreateProductResult(Guid Id);



internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Create a product entity form command object
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        //Save the product entity to the database


        //Return the Id of the new product
        return new CreateProductResult(Guid.NewGuid());

        throw new NotImplementedException();
    }
} 

