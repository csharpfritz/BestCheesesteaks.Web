/// <binding Clean='clean' />
'use strict';
var gulp = require("gulp"),
  rimraf = require("rimraf"),
  concat = require("gulp-concat"),
  cssmin = require("gulp-cssmin"),
  uglify = require("gulp-uglify"),
  less   = require("gulp-less");

var project = {};
project.webroot = ".";

var paths = {
  webroot: "./" + project.webroot + "/"
};

paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.css = paths.webroot + "css/**/*.css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";
paths.allLess = paths.webroot + "css/*.less";
paths.less = paths.webroot + "css/app.less";

gulp.task("clean:js", function(cb) {
  rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function(cb) {
  rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("copy", function() {
  
  gulp.src("bower_components/bootstrap/dist/**")
    .pipe(gulp.dest("wwwroot/lib/bootstrap"));
    
  gulp.src("bower_components/jquery/dist/jquery.min.js")
    .pipe(gulp.dest("wwwroot/lib/jquery"));  
  
});

gulp.task("min:js", function() {
  gulp.src([paths.js, "!" + paths.minJs], {
      base: "."
    })
    .pipe(concat(paths.concatJsDest))
    .pipe(uglify())
    .pipe(gulp.dest("."));
});

gulp.task("min:css", function() {
  gulp.src([paths.css, "!" + paths.minCss])
    .pipe(concat(paths.concatCssDest))
    .pipe(cssmin())
    .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);

gulp.task("less", function() {
  
  gulp.src(paths.less)
    .pipe(less({
      compress: true
    })).pipe(gulp.dest(paths.webroot + "css/"));
  
})

gulp.task("watch:css", function() {
  gulp.watch([paths.css, "!" + paths.minCss], ["min:css"])
});

gulp.task("watch:js", function() {
  gulp.watch([paths.js, "!" + paths.minJs], ["min:js"])
})

gulp.task("watch:less", function() {

  gulp.watch(paths.allLess, ["less"]);

});

gulp.task("watch", ["watch:css", "watch:js", "watch:less"]);

gulp.task("default", ["copy", "min:css", "min:js"]);