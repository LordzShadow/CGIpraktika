// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

Vue.use(Autocomplete);
movies = {}

var notfound = new Vue({
  el: '#notfound',
  data: {
    show: false
  },
  methods: {
    showall: function (event) {
      this.show = false;
      vu.fetch(true);
    }
  }
})
var searchbar = new Vue({
  el: '#searchbar',
  data: {
    result: null
  },
  methods: {
    search: function (event) {
        notfound.show = false;
        s_title = $("#search_in").val();
        let found = false;
        vu.info = [];
        movies.forEach(function(entry) {
          if (entry.title.toLowerCase().includes(s_title.toLowerCase())) {
            vu.info.push(entry);
            found = true;
          }
        })
        if (!found) {
          notfound.show = true;
        }
        // axios
        //   .get('/api/fetchbyid?id='+id)
        //   .then(response => (this.result = response.data))
        //   .then(vu.fetch)
        //   .catch(error => console.log(error));
        
    },
    auto(input) {
      if (input.length < 1) { return []}
      return movies.filter(movie => {
        return movie.title.toLowerCase().includes(input.toLowerCase())
      })
    },
    getResultValue(result) {
      return result.title
    }
  }
})

var vu = new Vue({
    el: '#app',
    data: {
        info: null,
        cats: null
    },
    mounted () {
      this.fetch(true);
    },
    methods: {
      fetch: function (first = false) {
        if (searchbar.result == null) {
          if (first) {
            axios
            .get('/api/fetch')
            .then(response => (this.info = response.data, movies = response.data))
            .catch(error => console.log(error));
            axios
            .get('/api/fetchcat')
            .then(response => (this.cats = response.data))
            .catch(error => console.log(error))
          } else {
            axios
            .get('/api/fetch')
            .then(response => (this.info = response.data))
            .catch(error => console.log(error))
          }
        } else {
          this.info = [searchbar.result];
        }
      }
    }
  }
  )

var f_menu = new Vue({
  el: '#menu',
  data: {
    filters: {
      action: false,
      drama: false,
      comedy: false,
      romance: false,
      crime: false
    },
  },
  methods: {
    toggle: function (name) {
      this.filters[name] = !this.filters[name];
      this.scan();
    },
    scan: function () {
      notfound.show = false;
      vu.info = [];
      var found = false;
      var filter_on = false;
      vu.cats.forEach(function (cat) {
        if (this.filters[cat.name.toLowerCase()]) {
          filter_on = true;
          movies.forEach( function (movie) {
            if (movie.categoryId == cat.id) {
              vu.info.push(movie);
              found = true;
            }
          })
        }
      }, this)
      if (!found && filter_on) {
        notfound.show = true;
      } else if (!filter_on) {
        vu.info = movies;
      }
    }
  }
})

// kood kopeeritud stackoverflowst
$('#searchbar').on('keyup keypress', function(e) {
  var keyCode = e.keyCode || e.which;
  if (keyCode === 13) {
    searchbar.search(); 
    e.preventDefault();
    return false;
  }
});


// Enamus koodist all pool saadud bootstrapi dokumentatsioonist, veidi muudetud
$('#exampleModal').on('show.bs.modal', function (event) {
  var button = $(event.relatedTarget); // Button that triggered the modal
  var movieid = button.attr('data-id'); // Extract info from data-* attributes
  var movie;
  movies.forEach(function(entry) {
    if (entry.id == movieid) {
      movie = entry;
    }
  })
  // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
  // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
  var modal = $(this);
  modal.find('.modal-title').text(movie.title);
  modal.find('#desc').text(movie.description);
  modal.find('#rating').text(movie.rating + "/10");
  modal.find('#year').text(movie.year);
})

$('.filter-btn').bind('click', function (e) { e.stopPropagation(); $(this).button('toggle') })
