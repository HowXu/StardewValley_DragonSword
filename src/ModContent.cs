namespace DragonSword;

using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley.GameData.Weapons;

// This file include Mod Content
public class ModContent{
    //这个方法注册物品
    private IModHelper helper; //i18n本地化
    public ModContent(IModHelper modHelper){
        helper = modHelper;
    }
    public void OnSwordRegister(object? sender,AssetRequestedEventArgs eventArgs){//event是保留关键字 不能当变量名
        //这个if嵌入到武器注册中
        if(eventArgs.Name.IsEquivalentTo("Data/Weapons")){
            //AssetRequestedEventArgs.Edit(Action<IAssetData>, AssetEditPriority, string?)
            //参数第一个值是委托
            eventArgs.Edit(Asset => {

                var dict = Asset.AsDictionary<string,WeaponData>();//获得SMAPI从游戏中拉出来的武器数据的字典
                //设置字典的新键值
                dict.Data["Dragon_Sword"] = new WeaponData{
                    Name = "Dragon_Sword",
                    DisplayName = helper.Translation.Get("DragonSword"),
                    Description = helper.Translation.Get("DragonSword_Description"),
                    //数据设置 反正无敌就完事了奥
                    MinDamage = 999999999,
                    MaxDamage = 999999999,
                    Knockback = 1.5f,
                    Speed = 10,
                    Precision = int.MaxValue - 999999,
                    Defense = int.MaxValue,
                    AreaOfEffect = int.MaxValue - 999999,
                    CritChance = 1.0f,
                    CritMultiplier = 1.0f,
                    CanBeLostOnDeath = false,
                    Texture = "Dragon_Sword"
                };
            });
        }
        //这个if为武器设置贴图
        if(eventArgs.Name.IsEquivalentTo("Dragon_Sword")){
            eventArgs.LoadFromModFile<Texture2D>("assets/dragon_sword.png",AssetLoadPriority.High);
        }
    }
}