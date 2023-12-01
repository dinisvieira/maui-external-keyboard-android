# Maui Android Bug Repro when using external keyboard

When using an Entry on Android with **ReturnType="Go"** and a **ReturnCommand** it doesn't get called when using an external keyboard.
This project allows experimenting with this:


**Steps for bug (external keyboard):**
- Run app and enter some text on Entry
- Press "Enter" on an external keyboard (for example using an Emulator on a computer and using the computer's keyboard)
- **Result:** Instead of executing the command the app changes Focus to the next item (in this case it's the Switch)

**Steps that work (internal keyboard):**
- Run app and enter some text on Entry
- Press the submit button using the "internal" keyboard
- **Result:** Command executes as it should
