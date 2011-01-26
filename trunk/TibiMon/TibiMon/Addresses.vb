Module Addresses
    Public Const Exp As Long = &H63FD50 '8.7
    Public Const ID As Long = Exp + 16 '8.7
    Public Const StepCreatures As Long = 172 '8.7
    Public Const MaxCreatures As Long = 1300 '8.7
    Public Const Battlelist_Begin As Long = &H63FDE8 '8.7
    Public Const Battlelist_End As Long = Battlelist_Begin + (StepCreatures * MaxCreatures) '8.7
    Public Const HP As Long = Exp + 12 '8.7
    Public Const HP_Max As Long = Exp + 8

    Public Const FrameratePointer As Long = &H7C9DD4
    Public Const FrameRateCurrentOffset As Long = &H60
    Public Const FrameRateLimitOffset As Long = &H58

    Public Const ChatPointer As Long = &H42C140
    Public Const ChatPointer2 As Long = &H42C574
    Public Const StartTime As Long = &H80CAF0
    Public Const LastMSGtext As Long = ChatPointer2 + &H40
    Public Const LastMSGauthor As Long = LastMSGtext - &H28
    Public Const StatusbarText As Long = StartTime + &H20
    Public Const StatusbarTime As Long = StatusbarText - 4

    Public Const Level As Long = Exp - 4
    Public Const MagicLevel As Long = Exp - 8
    Public Const Level_Percent As Long = Exp - 12
    Public Const MagicLevel_Percent As Long = Exp - 16

    Public Const Mana As Long = &H63FD38 '8.7
    Public Const Mana_Max As Long = Mana - 4

    Public Const Soul As Long = Exp - 28
    Public Const Stamina As Long = Exp - 32
    Public Const Cap As Long = Exp - 36

    Public Const Fishing As Long = Fist_Percent + 52
    Public Const Shielding As Long = Fist_Percent + 48
    Public Const Distance As Long = Fist_Percent + 44
    Public Const Axe As Long = Fist_Percent + 40
    Public Const Sword As Long = Fist_Percent + 36
    Public Const Club As Long = Fist_Percent + 32
    Public Const Fist As Long = Fist_Percent + 28

    Public Const Fishing_Percent As Long = Fist_Percent + 24
    Public Const Shielding_Percent As Long = Fist_Percent + 20
    Public Const Distance_Percent As Long = Fist_Percent + 16
    Public Const Axe_Percent As Long = Fist_Percent + 12
    Public Const Sword_Percent As Long = Fist_Percent + 8
    Public Const Club_Percent As Long = Fist_Percent + 4
    Public Const Fist_Percent As Long = Flags + 4
    Public Const Flags As Long = Exp - 112 '8.7
    Public Const Max_Slots As Long = 11
    Public Const Slot_Head As Long = &H6380E8 '' 8.40
    Public Const Slot_Neck As Long = Slot_Head + 12
    Public Const Slot_Backpack As Long = Slot_Head + 24
    Public Const Slot_Armor As Long = Slot_Head + 36
    Public Const Slot_Right As Long = Slot_Head + 48
    Public Const Slot_Left As Long = Slot_Head + 60
    Public Const Slot_Legs As Long = Slot_Head + 72
    Public Const Slot_Feet As Long = Slot_Head + 84
    Public Const Slot_Ring As Long = Slot_Head + 96
    Public Const Slot_Ammo As Long = Slot_Head + 108

    Public Const Distance_Slot_Count As Long = 4
    Public Const Slot_Right_Count As Long = Slot_Right + Distance_Slot_Count
    Public Const Slot_Left_Count As Long = Slot_Left + Distance_Slot_Count
    Public Const Slot_Ammo_Count As Long = Slot_Ammo + Distance_Slot_Count

    Public Const CurrentTileToGo As Long = &H62BD38
    Public Const TilesToGo As Long = &H62BD3C


    Public Const RedSquare As Long = Flags + 68 '8.7
    Public Const GreenSquare As Long = RedSquare - 4 '8.7
    Public Const WhiteSquare As Long = GreenSquare - 4 '8.7

    Public Const Target_ID As Long = RedSquare
    Public Const Target_BList_ID As Long = Target_ID - 8
    Public Const Target_BList_Type As Long = Target_ID - 5
    Public Const Target_Type As Long = Target_ID + 3


    Public Const z As Long = &H67BA30
    Public Const Y As Long = z + 4
    Public Const X As Long = z + 8

End Module
