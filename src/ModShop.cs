using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley.GameData.Shops;

namespace DragonSword;

public class ModShop{
    private IModHelper helper; 
    public ModShop(IModHelper modHelper){
        helper = modHelper;
    }
    //在冒险家工会添加物品出售
    public void onShopRegister(object? sender,AssetRequestedEventArgs eventArgs){
        if(eventArgs.Name.IsEquivalentTo("Data/Shops")){
            //System.Console.WriteLine("Invoke");
            eventArgs.Edit(asset => {
                var dict = asset.AsDictionary<string,ShopData>();
                dict.Data["AdventureShop"].Items.Add(new(){
                        Id = "Dragon_Sword",
                        Price = 1634,
                        TradeItemId = "(W)0",
                        TradeItemAmount = 1,
                        ItemId = "Dragon_Sword",
                    }
                );
            });
            
        }
    }
}