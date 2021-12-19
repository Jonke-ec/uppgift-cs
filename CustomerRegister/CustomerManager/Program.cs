using CustomerManager;
using System.IO;

MenuHandler menu = new MenuHandler();

int menuOption = -1;

do {

    menuOption = menu.MainMenu();

    switch (menuOption) {
        case 1:
            CreateCustomer.Create();
            break;
        case 2:
            CreateCustomer.LoadList();
            break;
        case 3:
            CreateCustomer.DiscountAutoGenerator();
            break;
        case 4:
            CreateCustomer.RemoveCustomer();
            break;
        default:
            break;
    }

} while (menuOption != 0);

