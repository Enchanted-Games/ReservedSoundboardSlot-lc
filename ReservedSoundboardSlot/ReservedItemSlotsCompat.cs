using ReservedItemSlotCore.Data;

public static class ReservedItemSlotsCompat
{
    public static void AddItemsToReservedItemSlots()
    {
        ReservedItemSlotData soundboardItemSlot = ReservedItemSlotData.CreateReservedItemSlotData("soundboard_item_slot", 20, 100);

        ReservedItemData soundboardReservedItemData = new ReservedItemData("Soundboard");

        soundboardItemSlot.AddItemToReservedItemSlot(soundboardReservedItemData);
    }
}