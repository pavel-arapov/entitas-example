//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ForwardMovementComponent forwardMovement { get { return (ForwardMovementComponent)GetComponent(GameComponentsLookup.ForwardMovement); } }
    public bool hasForwardMovement { get { return HasComponent(GameComponentsLookup.ForwardMovement); } }

    public void AddForwardMovement(float newSpeed) {
        var index = GameComponentsLookup.ForwardMovement;
        var component = (ForwardMovementComponent)CreateComponent(index, typeof(ForwardMovementComponent));
        component.speed = newSpeed;
        AddComponent(index, component);
    }

    public void ReplaceForwardMovement(float newSpeed) {
        var index = GameComponentsLookup.ForwardMovement;
        var component = (ForwardMovementComponent)CreateComponent(index, typeof(ForwardMovementComponent));
        component.speed = newSpeed;
        ReplaceComponent(index, component);
    }

    public void RemoveForwardMovement() {
        RemoveComponent(GameComponentsLookup.ForwardMovement);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherForwardMovement;

    public static Entitas.IMatcher<GameEntity> ForwardMovement {
        get {
            if (_matcherForwardMovement == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ForwardMovement);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherForwardMovement = matcher;
            }

            return _matcherForwardMovement;
        }
    }
}
