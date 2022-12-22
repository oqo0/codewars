// https://www.codewars.com/kata/58b1ae711fcffa34090000ea/

using System;

public class Door
{
  private string _doorPositions = "";
  private DoorState _currentState = DoorState.Opening;
  private bool _paused = true;
  private int _currentPosition = 0;
  
  private int CurrentPosition
  {
    get => _currentPosition;
    set
    {
      if (value < 0)
      {
        _paused = true;
        _currentState = DoorState.Opening;
        return;
      }
      
      if (value > 5)
      {
        _paused = true;
        _currentState = DoorState.Closing;
        return;
      }
      
      _currentPosition = value;
    }
  }
  
  private enum DoorState
  {
    Opening,
    Closing
  }
  
  private void PressButton() => _paused = _paused != true;
  
  private void DetectObstacle()
  {
    // when the door detects an obstacle, it reverses the
    // direction of movement
    if (_currentState == DoorState.Closing)
    {
      _currentState = DoorState.Opening;
      return;
    }
    if (_currentState == DoorState.Opening)
    {
      _currentState = DoorState.Closing;
      return;
    }
  }
  
  private void MovementHandler()
  {
    if (_currentState == DoorState.Opening && _paused == false)
    {
      CurrentPosition++;
    }
    if (_currentState == DoorState.Closing && _paused == false)
    {
      CurrentPosition--;
    }
    
    _doorPositions += CurrentPosition.ToString();
  }
  
  public string ProcessEvents(string events)
  {
    foreach (char c in events)
    {
      if (c == 'P')
        PressButton();
      if (c == 'O')
        DetectObstacle();
      
      MovementHandler();
    }
    
    return _doorPositions;
  }
}