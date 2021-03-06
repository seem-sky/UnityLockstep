//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Lockstep.Core.State.Game.RvoAgentSettingsComponent rvoAgentSettings { get { return (Lockstep.Core.State.Game.RvoAgentSettingsComponent)GetComponent(GameComponentsLookup.RvoAgentSettings); } }
    public bool hasRvoAgentSettings { get { return HasComponent(GameComponentsLookup.RvoAgentSettings); } }

    public void AddRvoAgentSettings(BEPUutilities.Vector2 newPreferredVelocity, FixMath.NET.Fix64 newTimeHorizonObst, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<FixMath.NET.Fix64, uint>> newAgentNeighbors) {
        var index = GameComponentsLookup.RvoAgentSettings;
        var component = (Lockstep.Core.State.Game.RvoAgentSettingsComponent)CreateComponent(index, typeof(Lockstep.Core.State.Game.RvoAgentSettingsComponent));
        component.preferredVelocity = newPreferredVelocity;
        component.timeHorizonObst = newTimeHorizonObst;
        component.agentNeighbors = newAgentNeighbors;
        AddComponent(index, component);
    }

    public void ReplaceRvoAgentSettings(BEPUutilities.Vector2 newPreferredVelocity, FixMath.NET.Fix64 newTimeHorizonObst, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<FixMath.NET.Fix64, uint>> newAgentNeighbors) {
        var index = GameComponentsLookup.RvoAgentSettings;
        var component = (Lockstep.Core.State.Game.RvoAgentSettingsComponent)CreateComponent(index, typeof(Lockstep.Core.State.Game.RvoAgentSettingsComponent));
        component.preferredVelocity = newPreferredVelocity;
        component.timeHorizonObst = newTimeHorizonObst;
        component.agentNeighbors = newAgentNeighbors;
        ReplaceComponent(index, component);
    }

    public void RemoveRvoAgentSettings() {
        RemoveComponent(GameComponentsLookup.RvoAgentSettings);
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

    static Entitas.IMatcher<GameEntity> _matcherRvoAgentSettings;

    public static Entitas.IMatcher<GameEntity> RvoAgentSettings {
        get {
            if (_matcherRvoAgentSettings == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RvoAgentSettings);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRvoAgentSettings = matcher;
            }

            return _matcherRvoAgentSettings;
        }
    }
}
