# ScriptableEvents

This is a event system made for Unity which has been based on a [Unite 2017 talk by Ryan Hipple](https://youtu.be/raQ3iHhE_Kk). 
It's also heavily inspired by [NeoDragonPC's improved version on this talk's implementation](https://github.com/NeoDragonCP/Unity-ScriptableObjects-Game-Events-)
The big difference here is that this implementation uses Generic Types, so a new Event can be created fairly easily.  
Another difference is that you can chose which DataType you want to listen for, instead of having a single Listener which has 4 Response fields, which fills the entire screen.

## Installation
To install this just download the source and copy the `ScriptableEvents` folder in Assets to your existing project. 

## Usage
You need to have an Event made before you can use this. So let's start with creating an event.  
This can be done by right clicking anywhere in the project window, selecting `Scriptables` and then your desired event.  
For this example we'll go with `Integer Event`.  
Now create a GameObject and give it the `Integer Event Listener` script.  
Now you can add a new `Response` by increasing the size and dropping the `Integer Event` in the Event field.  
You can now add new methods that should be executed when the Event is raised.  
Testing if the `Response` is executing the method can be done by going in Play mode, selecting the `Integer Event` and clicking Raise.  
This will fire off the Event and should execute the method you have assigned to the `Response`.  
You can also send some data with this event. This can be done by calling `IntegerEvent.Sent = {value}`. 
This value can be used by creating a method which needs the specified datatype, in this case, an int.  
If you create a method like this  
```csharp
public class TestUI : MonoBehaviour {
    public void Multiply(int amount) {}
}
```
And assign this method to the Listener, you can select a Dynamic int option. If this is selected the int that was send will be used as the parameter.

## Creating a new Scriptable Event
I recommend you to check out the Example scene and look at the DamageStat events.  
This will show you exactly what scripts need to be created, and what fields they are required to have.  

To create a new `ScriptableEvent` a new extension of `AbstractEvent` is needed.  
Simply create a new script file and make it extend AbstractEvent
```csharp
[CreateAssetMenu(menuName = "Scriptables/DamageStat Event")]
public class DamageStatEvent : AbstractEvent<DamageStat> { }
```
The Event can't work on itself, it also needs a script which listens to this event, 
and lets other GameObjects know when this event is raised.  

An EventListener is needed. Create a new script and make it extend AbstractEventListener.  
```csharp
public class DamageStatEventListener : AbstractEventListener<DamageStat>
{
    public List<DamageStatResponse> Responses = new List<DamageStatResponse>();
    public override List<AbstractEventResponse<DamageStat>> GetResponse()
    {
        return new List<AbstractEventResponse<DamageStat>>(Responses);
    }
}
```
As you can see, the Listener has Responses. These Responses are invoked when the Event that is being listened to is Raised.  
If a new Response isn't created, the Event can't use the value you send by calling `Event.Sent = {value}`.  
A new ResponseWith{Value} is also needed.
```csharp
[Serializable] public class ResponseWithDamageStat : ResponseWithGeneric<DamageStat> {}
```
To create a Response simply extend `AbstractEventResponse`  
```csharp
[Serializable]
    public class DamageStatResponse : AbstractEventResponse<DamageStat>
    {
        public DamageStatEvent Event;
        public UnityEvent Response;
        public ResponseWithDamageStat ResponseWithData;

        public override AbstractEvent<DamageStat> GetEvent() { return Event; }
        protected override UnityEvent GetResponse() { return Response; }
        protected override ResponseWithGeneric<DamageStat> GetResponseWithData() { return ResponseWithData; }
    }
```
That's it. You can now use this Event and Listen to it.

