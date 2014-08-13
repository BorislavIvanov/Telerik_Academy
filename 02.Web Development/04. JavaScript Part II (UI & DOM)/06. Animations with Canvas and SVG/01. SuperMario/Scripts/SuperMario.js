/// <reference path="kinetic-v5.1.0.min.js" />

// Canvas
function SuperMario(x, y, layer, stage) {
    var superMario = {
        posX: x,
        posY: y,
        image: (function (x, y) {
            var mario = new Image();
            mario.src = '/Resources/Mario Hi-Res.png';

            var marioAnimation = new Kinetic.Sprite({
                x: x,
                y: y,
                width: 650,
                height: 50,
                image: mario,
                animation: 'normalState',
                animations: {
                    normalState: [
                        // x, y, width, height
                        608, 659, 170, 250
                    ],
                    movingState: [
                        560, 985, 240, 260,
                        25, 970, 235, 265,
                        860, 660, 200, 220
                    ]
                },
                frameRate: 10,
                frameIndex: 0
            });

            layer.add(marioAnimation);
            stage.add(layer);
            marioAnimation.start();

            var frameCount = 0;

            marioAnimation.on('frameIndexChange', function (evt) {
                if (marioAnimation.animation() === 'movingState' && ++frameCount > 3) {
                    window.removeEventListener('keydown', onKeyDown);
                    marioAnimation.animation('normalState'); // restore original animation
                    //marioAnimation.scaleX(1); // restore original animation
                    frameCount = 0;
                    window.addEventListener('keydown', onKeyDown);
                }
            });

            function onKeyDown(evt) {
                switch (evt.keyCode) {
                    case 37:  // LeftArrow
                        marioAnimation.setX(marioAnimation.attrs.x -= 50);
                        marioAnimation.scaleX(1);
                        marioAnimation.attrs.animation = "movingState";
                        break;
                    case 39:  // RightArrow
                        marioAnimation.setX(marioAnimation.attrs.x += 50);
                        marioAnimation.scaleX(-1); // this scale reverses the mario
                        marioAnimation.attrs.animation = "movingState";
                        break;
                }
            }

            window.addEventListener('keydown', onKeyDown);

            return marioAnimation;
        })(x, y)
    }

    return SuperMario;
}

