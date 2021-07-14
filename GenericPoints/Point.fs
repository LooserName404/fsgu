namespace GenericPoints

type Point<'a> = { X: 'a; Y: 'a }

module Point =
    
    let inline moveBy (dx: 'a) (dy: 'a) (p: Point<'a>) =
        {
            X = p.X + dx
            Y = p.Y + dy
        }