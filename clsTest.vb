Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Translator

<TestClass()>
Public Class clsTest

   <TestMethod()>
   Public Sub TextLadenTesten()
      Try
         Dim Text As String = "bedGroupDesc,blocks,Block,EnChanged,Placing it on the ground will let you spawn there when you die. It shows on your map and prevents zombie respawn. Only the last placed one will be active.,""En le plaçant à terre, vous pourrez réapparaître à cet endroit lorsque vous mourrez et il sera indiqué sur votre carte."",""Wenn du dies platzierst, kannst du dort wiedererscheinen, falls du stirbst. Außerdem wird der Standort auf deiner Karte angezeigt."""

         Dim TextManager As New clsTextDataManager
         Dim list As ArrayList = TextManager.createDatasetRow(Text)
         Assert.AreEqual("bedGroupDesc", list(0), "Spalte 0 falsch eingelesen")
         Assert.AreEqual("blocks", list(1), "Spalte 1 falsch eingelesen")
         Assert.AreEqual("Block", list(2), "Spalte 2 falsch eingelesen")
         Assert.AreEqual("EnChanged", list(3), "Spalte 3 falsch eingelesen")
         Assert.AreEqual("Placing it on the ground will let you spawn there when you die. It shows on your map and prevents zombie respawn. Only the last placed one will be active.", list(4), "Spalte 4 falsch eingelesen")
         Assert.AreEqual("En le plaçant à terre, vous pourrez réapparaître à cet endroit lorsque vous mourrez et il sera indiqué sur votre carte.", list(5), "Spalte 5 falsch eingelesen")
         Assert.AreEqual("Wenn du dies platzierst, kannst du dort wiedererscheinen, falls du stirbst. Außerdem wird der Standort auf deiner Karte angezeigt.", list(6), "Spalte 6 falsch eingelesen")

         Text = "airConditionVentFanDouble,blocks,Block,New,""Vent Fan, Double"",,,,,"
         list = TextManager.createDatasetRow(Text)
         Assert.AreEqual("airConditionVentFanDouble", list(0), "Spalte 0 falsch eingelesen")
         Assert.AreEqual("blocks", list(1), "Spalte 1 falsch eingelesen")
         Assert.AreEqual("Block", list(2), "Spalte 2 falsch eingelesen")
         Assert.AreEqual("New", list(3), "Spalte 3 falsch eingelesen")
         Assert.AreEqual("Vent Fan, Double", list(4), "Spalte 4 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(5), "Spalte 5 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(6), "Spalte 6 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(7), "Spalte 7 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(8), "Spalte 8 falsch eingelesen")

         Text = "cntBagsRandomLootHelperDesc,blocks,Block,New,""Will randomly spawn bags, backpacks, and purses (50%), small trash (25%) or nothing (25%)."",,,,,"
         list = TextManager.createDatasetRow(Text)
         Assert.AreEqual("cntBagsRandomLootHelperDesc", list(0), "Spalte 0 falsch eingelesen")
         Assert.AreEqual("blocks", list(1), "Spalte 1 falsch eingelesen")
         Assert.AreEqual("Block", list(2), "Spalte 2 falsch eingelesen")
         Assert.AreEqual("New", list(3), "Spalte 3 falsch eingelesen")
         Assert.AreEqual("Will randomly spawn bags, backpacks, and purses (50%), small trash (25%) or nothing (25%).", list(4), "Spalte 4 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(5), "Spalte 5 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(6), "Spalte 6 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(7), "Spalte 7 falsch eingelesen")
         Assert.AreEqual(String.Empty, list(8), "Spalte 8 falsch eingelesen")
      Catch ex As Exception
         Assert.Fail(ex.Message)
      End Try
   End Sub

End Class
