using Terraria;

namespace UseDuplicatedAccessories {
  public class UseDuplicatedAccessories : Terraria.ModLoader.GlobalItem {

    public override bool CanAccessoryBeEquippedWith(
      Item equippedItem, Item incomingItem, Player player
    ) {
      return false;
    }
  }
}
