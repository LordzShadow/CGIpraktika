// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

Vue.use(Autocomplete);
movies = {}

var searchbar = new Vue({
  el: '#searchbar',
  data: {
    result: null
  },
  methods: {
    search: function (event) {
        s_title = $("#search_in").val();
        let found = false;
        movies.forEach(function(entry) {
          if (entry.title == s_title) {
            console.log("found!")
            vu.info = [entry];
            found = true;
          }
        })
        if (!found) {
          vu.info = movies;
        }
        // axios
        //   .get('/movies/fetchbyid?id='+id)
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
    },
    mounted () {
      this.fetch(true);
    },
    methods: {
      fetch: function (first = false) {
        console.log(movies)
        if (searchbar.result == null) {
          if (first) {
            console.log(1);
            axios
            .get('/movies/fetch')
            .then(response => (this.info = response.data, movies = response.data))
            .catch(error => console.log(error))
          } else {
            console.log("search:")
            axios
            .get('/movies/fetch')
            .then(response => (this.info = response.data))
            .catch(error => console.log(error))
          }
        } else {
          console.log(searchbar.result);
          this.info = [searchbar.result];
        }
      }
    }
  }
  )

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
  var button = $(event.relatedTarget) // Button that triggered the modal
  var movieid = button.attr('data-id') // Extract info from data-* attributes
  var movie;
  console.log(button)
  movies.forEach(function(entry) {
    if (entry.id == movieid) {
      console.log("found!");
      movie = entry;
    }
  })
  // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
  // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
  var modal = $(this)
  modal.find('.modal-title').text(movie.title)
  modal.find('#desc').text(movie.description)
  modal.find('#rating').text(movie.rating)
})