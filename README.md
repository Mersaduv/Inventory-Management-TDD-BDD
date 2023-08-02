# Inventory-Management-TDD-BDD

![Build Passing](https://raw.githubusercontent.com/dwyl/repo-badges/main/svg/build-passing.svg)

## Building a sample

```console
dotnet build
dotnet run
```

Project scenario gherkin language
    ```feature

    Feature: Inventory Management
        As A Aarehouse Keeper
        I Want To Keep Track Of My Inventory
        So That I Always Have Accurate Info About Products Stock


            Scenario: Defining New Inventory
            Given I Want To Add The Following Inventory
                | Product | UnitPrice |
                | IPhone  | 1100      |
            When I Try To Define This Inventory
            Then The Inventory Should Be Created
            And It Should Be Empty
    ```

To build and run your sample:

1. Go to the sample folder and build to check for errors:

    ```console
    dotnet build
    ```

2. Run your sample:

    ```console
    dotnet run
    ```
