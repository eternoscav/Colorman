    // A simple smooth follow camera,
    // that follows the targets forward direction
    var target : Transform;
    var smooth = 0.3;
    var distance = 5.0;
    private var yVelocity = 0.0;
    
    function Update () {
        // Damp angle from current y-angle towards target y-angle
        var yAngle : float = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                                    target.eulerAngles.y, yVelocity, smooth);
        // Position at the target
        var position : Vector3 = target.position;
        // Then offset by distance behind the new angle
        position += Quaternion.Euler(0, yAngle, 0) * Vector3 (0, 0, -distance);
        // Apply the position
        transform.position = position;
        // Look at the target
        transform.LookAt(target);
    }