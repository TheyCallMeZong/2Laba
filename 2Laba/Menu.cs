namespace _2Laba
{
    public class Menu
    {
        public List<MenuStructure> menus = new List<MenuStructure>();
        private MenuStructure menu = new MenuStructure();
        private MenuStructure menuHead = new MenuStructure();
        private List<MenuStructure> previos = new List<MenuStructure>();

        public Menu(string path)
        {
            using var reader = new StreamReader(path);
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                var text = line.Split(' ');

                if (text.Count() == 3)
                {
                    MenuStructure menu = new MenuStructure()
                    {
                        NumberHierarchy = Convert.ToInt32(text[0]),
                        Name = text[1],
                        Status = Convert.ToInt32(text[2]),
                    };

                    if (menu.NumberHierarchy > this.menu.NumberHierarchy)
                    {
                        this.menu.SubMenu.Add(menu);
                    }
                    else if (menu.NumberHierarchy > menuHead.NumberHierarchy)
                    {
                        var item = previos.LastOrDefault(x => x.NumberHierarchy == menu.NumberHierarchy - 1);
                        item.SubMenu.Add(menu);
                    }
                    else
                    {
                        menuHead = menu;
                        menus.Add(menuHead);
                    }
                    previos.Add(menu);
                    this.menu = menu;
                }
                else
                {
                    MenuStructure menu = new MenuStructure()
                    {
                        NumberHierarchy = Convert.ToInt32(text[0]),
                        Name = text[1],
                        Status = Convert.ToInt32(text[2]),
                        MethodName = text[3]
                    };

                    if (menu.NumberHierarchy > menuHead.NumberHierarchy)
                    {
                        if (menu.NumberHierarchy > this.menu.NumberHierarchy)
                        {
                            this.menu.SubMenu.Add(menu);
                        }
                        else
                        {
                            var item = previos.LastOrDefault(x => x.NumberHierarchy == menu.NumberHierarchy - 1);
                            item.SubMenu.Add(menu);
                        }
                    }
                    else
                    {
                        menus.Add(menu);
                    }
                }
            }
        }

        public void Show()
        {

        }
    }
}